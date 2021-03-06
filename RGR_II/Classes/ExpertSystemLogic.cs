﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static RGR_II.Classes.DatabaseInteraction;
using System.Data;

namespace RGR_II.Classes
{
    class ExpertSystemLogic
    {
        public struct SUBNODE_ONE
        {
            public byte FF;
            public byte FS;

            public SUBNODE_ONE Copy(SUBNODE_ONE S)
            {
                FF = S.FF;
                FS = S.FS;
                return this;
            }

            public SUBNODE_ONE Clear()
            {
                FF = 0;
                FS = 0;
                return this;
            }

            public bool Sr(SUBNODE_ONE S)
            {
                if (FF == 2 && S.FF != 2)
                    return false;
                if (FF > 2 && S.FF == 2)
                    return false;
                if (FS == 2 && S.FS != 2)
                    return false;
                if (FS > 2 && S.FS == 2)
                    return false;
                return true;
            }
            public void Set(byte One = 0, byte Two = 0)
            {
                FF = (One < 0) ? (((One == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
                FS = (Two < 0) ? (((Two == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
            }

            public bool CheckOR_0()
            {
                return ((FF == 0) ? (true) : (false)) | ((FS == 0) ? (true) : (false));
            }

            public bool CheckOR_2()
            {
                return ((FF == 2) ? (true) : (false)) | ((FS == 2) ? (true) : (false));
            }

            public bool CheckOR_1()
            {
                return ((FF == 1) ? (true) : (false)) | ((FS == 1) ? (true) : (false));
            }

            public bool CheckXOR(byte b)
            {
                return ((FF ^ b + FS ^ b) == 0) ? (true) : (false);
            }
        };

        public struct SUBNODE_TWO
        {
            public byte FF;
            public byte FS;
            public byte FT;

            public SUBNODE_TWO Copy(SUBNODE_TWO S)
            {
                FF = S.FF;
                FS = S.FS;
                FT = S.FT;
                return this;
            }

            public SUBNODE_TWO Clear()
            {
                FF = 0;
                FS = 0;
                FT = 0;
                return this;
            }

            public bool Sr(SUBNODE_TWO S, bool f = false)
            {
                if (!f)
                {
                    if (FF == 2 && S.FF != 2)
                        return false;
                    if (FF > 2 && S.FF == 2)
                        return false;
                    if (FS == 2 && S.FS != 2)
                        return false;
                    if (FS > 2 && S.FS == 2)
                        return false;
                    if (FT == 2 && S.FT != 2)
                        return false;
                    if (FT > 2 && S.FT == 2)
                        return false;
                    return true;
                }
                if(FF == 1 && S.FF < 0)
                    return true;
                if (FS == 1 && S.FS != 1 && S.FF != 2)
                    return true;
                if (FT == 1 && S.FT != 1 && S.FF != 2 && S.FS != 2)
                    return true;
                return false;

            }
            public void Set(byte One = 0, byte Two = 0, byte Three = 0)
            {
                FF = (One < 0) ? (((One == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
                FS = (Two < 0) ? (((Two == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
                FT = (Three < 0) ? (((Three == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
            }

            public bool CheckOR_0()
            {
                return ((FF == 0) ? (true) : (false)) | ((FS == 0) ? (true) : (false)) | ((FT == 0) ? (true) : (false));
            }

            public bool CheckOR_2()
            {
                return ((FF == 2) ? (true) : (false)) | ((FS == 2) ? (true) : (false)) | ((FT == 2) ? (true) : (false));
            }

            public bool CheckOR_1()
            {
                return ((FF == 1) ? (true) : (false)) | ((FS == 1) ? (true) : (false)) | ((FT == 1) ? (true) : (false));
            }

            public bool CheckXOR(byte b)
            {
                return ((FF^b+FS^b+FT^b)==0) ? (true) : (false);
            }
        }

        public struct NODE
        {
            public SUBNODE_TWO AktivniiOtdih;//3 - byte
            public SUBNODE_ONE OtdihVKompanii;//5 - byte
            public byte Prirodu;//6 - byte
            public byte OtdihNaPrirode;//8 - byte
            public SUBNODE_ONE Arhitectura;//11 - byte
            public SUBNODE_TWO BolshieGoroda;//13 - byte
            public SUBNODE_ONE MalenkieGoroda;//14 - byte
            public byte Dostoprimechatelnosti;//16 - byte
            public SUBNODE_ONE VoennaaTematika;//19 - byte
            public SUBNODE_TWO Reki;//22 - byte
            public SUBNODE_TWO Gori;//25 - byte
            public SUBNODE_TWO SostoanieZdorovia;//28 - byte
            public SUBNODE_ONE Temp_Hight;//30 - byte
            public SUBNODE_ONE Temp_Low;//32 - byte
            public byte Temp_Srednaa;//33 - byte

            /*
             * SUBNODE_ONE AktivniiOtdih;               -Активный Отдых
             *                      byte FF;            ---Предпочитает активный отдых
             *                      byte FS;            ---Любит смену обстановки
             *                      byte FT;            ---Экстримальный отдых
             * SUBNODE_ONE OtdihVKompanii;              -Отдых в компании
             *                      byte FF;            ---Большая компания
             *                      byte FS;            ---Маленькая компания
             * byte Prirodu;                            -Любит природу
             * byte OtdihNaPrirode;                     -Любит отдых на природе
             * SUBNODE_ONE Arhitectura;                 -Любит архитектуру
             *                      byte FF;            ---Исторические строения
             *                      byte FS;            ---Современные строения
             * SUBNODE_TWO BolshieGoroda;               -Любит большие города
             *                      byte FF;            ---Промышленные города
             *                      byte FS;            ---Столицы
             *                      byte FT;            ---Обласные центры
             * SUBNODE_ONE MalenkieGoroda;              -Любит маленькие города
             *                      byte FF;            ---Провинцыальные города
             *                      byte FS;            ---Села
             * byte Dostoprimechatelnosti;              -Любит достопримечательности
             * SUBNODE_ONE VoennaaTematika;             -Любит военную тематику
             *                      byte FF;            ---Музей военной техники
             *                      byte FS;            ---Парки славы
             * SUBNODE_TWO Reki;                        -Любит реки
             *                      byte FF;            ---Моря
             *                      byte FS;            ---Реки
             *                      byte FT;            ---Озера
             * SUBNODE_TWO Gori;                        -Любит горы
             *                      byte FF;            ---Высокие горы
             *                      byte FS;            ---холмы
             *                      byte FT;            ---с возможностью подьёма
             * SUBNODE_TWO SostoanieZdorovia;           -Состояние здоровья
             *                      byte FF;            ---Хорошее
             *                      byte FS;            ---Среднее
             *                      byte FT;            ---Тяжелое
             * SUBNODE_ONE Temp_Hight;                  -Любит высокую температуру
             *                      byte FF;            --- 30+
             *                      byte FS;            --- 25+ - 30+
             * SUBNODE_ONE Temp_Low;                    -Любит низкую температуру
             *                      byte FF;            --- -10 - 15+
             *                      byte FS;            --- -30 - -10
             * byte Temp_Srednaa;                       -Любит среднюю температуру 15-25
             */
            
            public bool Sr(NODE S)
            {
                bool flag = true & SostoanieZdorovia.Sr(S.SostoanieZdorovia, true);
                flag &= AktivniiOtdih.Sr(S.AktivniiOtdih);
                flag &= OtdihVKompanii.Sr(S.OtdihVKompanii);
                flag &= Arhitectura.Sr(S.Arhitectura);
                flag &= BolshieGoroda.Sr(S.BolshieGoroda);
                flag &= MalenkieGoroda.Sr(S.MalenkieGoroda);
                flag &= VoennaaTematika.Sr(S.VoennaaTematika);
                flag &= Reki.Sr(S.Reki);
                flag &= Gori.Sr(S.Gori);
                flag &= Temp_Hight.Sr(S.Temp_Hight);
                flag &= Temp_Low.Sr(S.Temp_Low);
                flag &= (Prirodu == 2 && S.Prirodu != 2) ? (false) : ((Prirodu > 2 && S.Prirodu == 2) ? (false) : (true));
                flag &= (OtdihNaPrirode == 2 && S.OtdihNaPrirode != 2) ? (false) : ((OtdihNaPrirode > 2 && S.OtdihNaPrirode == 2) ? (false) : (true));
                flag &= (Temp_Srednaa == 2 && S.Temp_Srednaa != 2) ? (false) : ((Temp_Srednaa > 2 && S.Temp_Srednaa == 2) ? (false) : (true));
                flag &= (Dostoprimechatelnosti == 2 && S.Dostoprimechatelnosti != 2) ? (false) : ((Dostoprimechatelnosti > 2 && S.Dostoprimechatelnosti == 2) ? (false) : (true));
                return flag;
            }
            public NODE Copy(NODE S)
            {
                AktivniiOtdih = S.AktivniiOtdih;
                OtdihVKompanii = S.OtdihVKompanii;
                Prirodu = S.Prirodu;
                Arhitectura = S.Arhitectura;
                BolshieGoroda = S.BolshieGoroda;
                MalenkieGoroda = S.MalenkieGoroda;
                Dostoprimechatelnosti = S.Dostoprimechatelnosti;
                VoennaaTematika = S.VoennaaTematika;
                Reki = S.Reki;
                Gori = S.Gori;
                SostoanieZdorovia = S.SostoanieZdorovia;
                OtdihNaPrirode = S.OtdihNaPrirode;
                Temp_Hight = S.Temp_Hight;
                Temp_Low = S.Temp_Low;
                Temp_Srednaa = S.Temp_Srednaa;
                return this;
            }

            public NODE Clear()
            {
                AktivniiOtdih = AktivniiOtdih.Clear();
                OtdihVKompanii = OtdihVKompanii.Clear();
                Prirodu = 0;
                Arhitectura = Arhitectura.Clear();
                BolshieGoroda = BolshieGoroda.Clear();
                MalenkieGoroda = MalenkieGoroda.Clear();
                Dostoprimechatelnosti = 0;
                VoennaaTematika = VoennaaTematika.Clear();
                Reki = Reki.Clear();
                Gori = Gori.Clear();
                SostoanieZdorovia = SostoanieZdorovia.Clear();
                OtdihNaPrirode = 0;
                Temp_Hight = Temp_Hight.Clear();
                Temp_Low = Temp_Low.Clear();
                Temp_Srednaa = 0;
                return this;
            }
        };

        public struct RULE
        {
            public int ID;
            public NODE Node;
            public string Name; 

            public void SetIdName(RULE R)
            {
                ID = R.ID;
                Name = R.Name;
            }

            public void Copy(RULE R)
            {
                ID = R.ID;
                Name = R.Name;
                Node.Copy(R.Node);
            }

            public void Clear()
            {
                ID = 0;
                Name = null;
                Node.Clear();
            }

            public Task<List<string>> CorrectRules(SqlConnection Connection)
            {
                List<RULE> ListNode = new List<RULE>();
                List<string> RuleNameStrings = new List<string>();
                RULE R = new RULE();
                R.Copy(this);
                ListNode = SELECTallRules(Connection, true, R, ListNode);
                for (int i = 0; i < ListNode.Count; ++i)
                {
                   if (R.Node.Sr(ListNode[i].Node))
                   {
                       RuleNameStrings.Add(ListNode[i].Name);
                   }
               }
               return Task.Run(() =>
               {
                   ListNode = SELECTallRules(Connection, true, R, ListNode);
                   for (int i = 0; i < ListNode.Count; ++i)
                   {
                       if (R.Node.Sr(ListNode[i].Node))
                       {
                           RuleNameStrings.Add(ListNode[i].Name);
                       }
                   }
                   return RuleNameStrings;
               });
            }

            public void NewRule(string _Name = null, byte AOff = 0, byte AOfs = 0, byte AOft = 0, byte OvKff = 0, byte OvKfs = 0, byte P = 0, byte OnP = 0, byte Aff = 0, byte Afs = 0, byte BGff = 0, byte BGfs = 0, byte BGft = 0, byte MGff = 0, byte MGfs = 0, byte D = 0, byte VTff = 0, byte VTfs = 0, byte Rff = 0, byte Rfs = 0, byte Rft = 0, byte Gff = 0, byte Gfs = 0, byte Gft = 0, byte SZff = 0, byte SZfs = 0, byte SZft = 0, byte THff = 0, byte THfs = 0, byte TLff = 0, byte TLfs = 0, byte TS = 0)
            {
                ID = 0;
                Name = _Name;
                Node.AktivniiOtdih.FF = AOff;
                Node.AktivniiOtdih.FS = AOfs;
                Node.AktivniiOtdih.FT = AOft;
                Node.OtdihVKompanii.FF = OvKff;
                Node.OtdihVKompanii.FS = OvKfs;
                Node.Prirodu = P;
                Node.OtdihNaPrirode = OnP;
                Node.Arhitectura.FF = Aff;
                Node.Arhitectura.FS = Afs;
                Node.BolshieGoroda.FF = BGff;
                Node.BolshieGoroda.FS = BGfs;
                Node.BolshieGoroda.FT = BGft;
                Node.MalenkieGoroda.FF = MGff;
                Node.MalenkieGoroda.FS = MGfs;
                Node.Dostoprimechatelnosti = D;
                Node.VoennaaTematika.FF = VTff;
                Node.VoennaaTematika.FS = VTfs;
                Node.Reki.FF = Rff;
                Node.Reki.FS = Rfs;
                Node.Reki.FT = Rft;
                Node.Gori.FF = Gff;
                Node.Gori.FS = Gfs;
                Node.Gori.FT = Gft;
                Node.SostoanieZdorovia.FF = SZff;
                Node.SostoanieZdorovia.FS = SZfs;
                Node.SostoanieZdorovia.FT = SZft;
                Node.Temp_Hight.FF = THff;
                Node.Temp_Hight.FS = THfs;
                Node.Temp_Low.FF = TLff;
                Node.Temp_Low.FS = TLfs;
                Node.Temp_Srednaa = TS;
            }
        }

      

        public static NODE SetNodeParam(NODE Node, byte Parameter, params bool[] values)
        {
            if (values.Length!= 2 && values.Length != 4 && values.Length != 6)
            {
                return Node;
            }  
            switch (Parameter)
            {
                case 1:
                    if (Parameter == 1 && values.Length != 6)
                    {
                        return Node;
                    }
                    Node.AktivniiOtdih.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));  
                    Node.AktivniiOtdih.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    Node.AktivniiOtdih.FT = (values[4]) ? ((byte)1) : ((values[5]) ? ((byte)2) : ((byte)0));
                    break;
                case 2:
                    if (Parameter == 2 && values.Length != 4)
                    {
                        return Node;
                    }
                    Node.OtdihVKompanii.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.OtdihVKompanii.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    break;
                case 3:
                    if (Parameter == 3 && values.Length != 2)
                    {
                        return Node;
                    }
                    Node.Prirodu = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    break;
                case 4:
                    if (Parameter == 4 && values.Length != 2)
                    {
                        return Node;
                    }
                    Node.OtdihNaPrirode = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    break;
                case 5:
                    if (Parameter == 5 && values.Length != 4)
                    {
                        return Node;
                    }
                    Node.Arhitectura.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.Arhitectura.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    break;
                case 6:
                    if (Parameter == 6 && values.Length != 6)
                    {
                        return Node;
                    }
                    Node.BolshieGoroda.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.BolshieGoroda.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    Node.BolshieGoroda.FT = (values[4]) ? ((byte)1) : ((values[5]) ? ((byte)2) : ((byte)0));
                    break;
                case 7:
                    if (Parameter == 7 && values.Length != 4)
                    {
                        return Node;
                    }
                    Node.MalenkieGoroda.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.MalenkieGoroda.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    break;
                case 8:
                    if (Parameter == 8 && values.Length != 2)
                    {
                        return Node;
                    }
                    Node.Dostoprimechatelnosti = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    break;
                case 9:
                    if (Parameter == 9 && values.Length != 4)
                    {
                        return Node;
                    }
                    Node.VoennaaTematika.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.VoennaaTematika.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    break;
                case 10:
                    if (Parameter == 10 && values.Length != 6)
                    {
                        return Node;
                    }
                    Node.Reki.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.Reki.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    Node.Reki.FT = (values[4]) ? ((byte)1) : ((values[5]) ? ((byte)2) : ((byte)0));
                    break;
                case 11:
                    if (Parameter == 11 && values.Length != 6)
                    {
                        return Node;
                    }
                    Node.Gori.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.Gori.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    Node.Gori.FT = (values[4]) ? ((byte)1) : ((values[5]) ? ((byte)2) : ((byte)0));
                    break;
                case 12:
                    if (Parameter == 12 && values.Length != 6)
                    {
                        return Node;
                    }
                    Node.SostoanieZdorovia.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.SostoanieZdorovia.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    Node.SostoanieZdorovia.FT = (values[4]) ? ((byte)1) : ((values[5]) ? ((byte)2) : ((byte)0));
                    break;
                case 13:
                    if (Parameter == 13 && values.Length != 4)
                    {
                        return Node;
                    }
                    Node.Temp_Hight.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.Temp_Hight.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    break;
                case 14:
                    if (Parameter == 14 && values.Length != 4)
                    {
                        return Node;
                    }
                    Node.Temp_Low.FF = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    Node.Temp_Low.FS = (values[2]) ? ((byte)1) : ((values[3]) ? ((byte)2) : ((byte)0));
                    break;
                case 15:
                    if (Parameter == 15 && values.Length != 2)
                    {
                        return Node;
                    }
                    Node.Temp_Srednaa = (values[0]) ? ((byte)1) : ((values[1]) ? ((byte)2) : ((byte)0));
                    break;
                default:
                    break;
            }
            return Node;
        }

        public static void DefaultRules(SqlConnection Connection)
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            RULE R = new RULE();
            R.NewRule("Sanatorii v gorah", SZft: 1, Gff: 1, Gfs: 1, Gft: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Sanatorii vozle vodi", SZft: 1, Rff: 1, Rfs: 1, Rft: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Sanatorii", SZft: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Otdih v palatkah", THff: 2, THfs: 2, SZfs: 1, SZff: 1, P: 1, OnP: 1, OvKff: 1, OvKfs: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Voennii muzei", VTff: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Park slavi", VTfs: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Gornolijnii kurort", Gff: 1, Gfs: 1, Gft: 1, SZfs: 1, SZff: 1, TLff: 1, TLfs: 1, AOff: 1, AOfs: 1, AOft: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Poezdka na more", Rff: 1, AOfs: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Poezdka na ozero", Rfs: 1, AOfs: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Poezdka na ozero", Rft: 1, AOfs: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Daiving", SZff: 1, Rff: 1, Rfs: 1, Rft: 1, AOft: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Alpinizm", SZff: 1, Gff: 1, Gfs: 1, Gft: 1, AOff: 1, AOft: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Ekskursia v gorod", OvKff: 1, OvKfs: 1, Aff: 1, Afs: 1, BGff: 1, BGfs: 1, BGft: 1, MGff: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Ekskursia v selo", Aff: 1, Afs: 1, MGfs: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Poezdka v mesto s istoricheskim naslediem", D: 1, Aff: 1, Afs: 1, P: 1, BGff: 1, BGfs: 1, BGft: 1, MGff: 1, MGfs: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Zapovedhik", OnP: 1, P: 1, D: 1);
            DoINSERTS(Connection, R);
            R.NewRule("Park", BGff: 1, BGfs: 1, BGft: 1, MGff: 1, MGfs: 1, OnP: 1, P: 1);
            DoINSERTS(Connection, R);
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
