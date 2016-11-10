using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            public bool Rule_Sanatorii_V_Gorah()
            {
                if (SostoanieZdorovia.FT != 0 && AktivniiOtdih.CheckOR_0() == true)
                {
                    return false;
                }
                if (Gori.FF != 0 || Gori.FS != 0 || Gori.FT != 0)
                {
                    return false;
                }
                return true;
            }

            public bool Rule_Sanatorii_U_Reki()
            {
                if (SostoanieZdorovia.FT != 0 && AktivniiOtdih.CheckOR_0() == true)
                {
                    return false;
                }
                if (Reki.FF != 0 || Reki.FS != 0 || Reki.FT != 0)
                {
                    return false;
                }
                return true;
            }

            public bool Rule_Sanatorii()
            {
                if (SostoanieZdorovia.FT != 0 && AktivniiOtdih.CheckOR_0() == true)
                {
                    return false;
                }
                return true;
            }

            public bool Rule_Otdih_V_Palatkah()
            {
                if (Temp_Hight.CheckOR_2() == true || SostoanieZdorovia.FT != 0)
                {
                    return false;
                }
                if ((Prirodu == 1 || OtdihNaPrirode == 1) && OtdihVKompanii.CheckOR_1() == true)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Voennii_Muzei()
            {
                if (VoennaaTematika.FF == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Rule_Park_Slavi()
            {
                if (VoennaaTematika.FS == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Rule_Gornolijnii_Kurort()
            {
                if (Temp_Low.CheckOR_2() == true || SostoanieZdorovia.FT != 1)
                {
                    return false;
                }
                if (Gori.CheckOR_1() == true && Temp_Low.CheckOR_1() == true && AktivniiOtdih.CheckOR_1() == true)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Poezdka_Na_More()
            {
                if (Reki.FF == 2)
                {
                    return false;
                }
                if (Reki.FF == 1 && AktivniiOtdih.FS == 1)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Poezdka_Na_Ozero()
            {
                if (Reki.FT == 2)
                {
                    return false;
                }
                if (Reki.FT == 1 && AktivniiOtdih.FS == 1)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Poezdka_Na_Reku()
            {
                if (Reki.FS == 2)
                {
                    return false;
                }
                if (Reki.FS == 1 && AktivniiOtdih.FS == 1)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Dayving()
            {
                if (SostoanieZdorovia.FT==1)
                {
                    return false;
                }
                if (Reki.CheckOR_1()==true && AktivniiOtdih.FT == 1 && AktivniiOtdih.FF == 1)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Alpinizm()
            {
                if (SostoanieZdorovia.FT == 1 && ((Temp_Low.CheckOR_0()==true && Temp_Srednaa==0 && Temp_Hight.FF==1 && Temp_Hight.FS==0)|| (Temp_Low.CheckOR_2() == true && Temp_Srednaa == 2 && Temp_Hight.FF == 1 && Temp_Hight.FS == 2)))
                {
                    return false;
                }
                if (Gori.CheckOR_1() == true  && AktivniiOtdih.FT == 1 && AktivniiOtdih.FF == 1)
                {
                    return true;
                }
                return false;
            }
            
            public bool Rule_Excursia_V_Gorod()
            {
                if (OtdihVKompanii.CheckOR_2()==true)
                {
                    return false;
                }
                if((Arhitectura.CheckOR_1()==true) && (BolshieGoroda.CheckOR_1()==true || MalenkieGoroda.FF ==1))
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Excursia_V_Sela()
            {
                if (OtdihVKompanii.CheckOR_2() == true)
                {
                    return false;
                }
                if ( Arhitectura.CheckOR_1() == true &&  MalenkieGoroda.FS == 1)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Goroda_S_Nasled()
            {
                if ((Dostoprimechatelnosti == 1 || Arhitectura.CheckOR_1() == true) && (BolshieGoroda.CheckOR_1() == true || MalenkieGoroda.FF == 1))
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Mesta_S_B_Nasled()
            {
                if ((Dostoprimechatelnosti == 1 || Arhitectura.CheckOR_1() == true) && (BolshieGoroda.CheckOR_1() == true || MalenkieGoroda.CheckOR_1() == true || Prirodu == 1))
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Zapovednik()
            {
                if (SostoanieZdorovia.FT != 0)
                {
                    return false;
                }
                if ((Dostoprimechatelnosti == 1 ) && ( Prirodu == 1) || OtdihNaPrirode ==1 || AktivniiOtdih.CheckOR_1()==true)
                {
                    return true;
                }
                return false;
            }

            public bool Rule_Park()
            { 
                if (AktivniiOtdih.CheckOR_2()==true && (Prirodu == 1 || OtdihNaPrirode == 1 || MalenkieGoroda.CheckOR_1()==true || BolshieGoroda.CheckOR_1()==true))
                {
                    return true;
                }
                return false;
            }
        };








        /*

        

        */
    }
}
