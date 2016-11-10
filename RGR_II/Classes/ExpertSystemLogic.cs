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
             * byte Temp_Srednaa;                       -Любит среднюю температуру
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
        };

        public static bool Rule_Sanatorii_V_Gorah(NODE S)
        {
            if(S.SostoanieZdorovia.FT !=0 && (S.AktivniiOtdih.FF != 0 || S.AktivniiOtdih.FS !=0 || S.AktivniiOtdih.FT != 0))
            {
                return false;
            }
            if(S.Gori.FF != 0  || S.Gori.FS != 0  || S.Gori.FT != 0)
            {
                return false;
            }
            return true;
        }

        public static bool Rule_Sanatorii_U_Reki(NODE S)
        {
            if (S.SostoanieZdorovia.FT != 0 && (S.AktivniiOtdih.FF != 0 || S.AktivniiOtdih.FS != 0 || S.AktivniiOtdih.FT != 0))
            {
                return false;
            }
            if (S.Reki.FF != 0 || S.Reki.FS != 0 || S.Reki.FT != 0)
            {
                return false;
            }
            return true;
        }

        public static bool Rule_Sanatorii(NODE S)
        {
            if (S.SostoanieZdorovia.FT != 0 && (S.AktivniiOtdih.FF != 0 || S.AktivniiOtdih.FS != 0 || S.AktivniiOtdih.FT != 0))
            {
                return false;
            }
            return true;
        }

        public static bool Rule_Otdih_V_Palatkah(NODE S)
        {

            return true;
        }

        public static bool Rule_Voennii_Muzei(NODE S)
        {
            if(S.VoennaaTematika.FF == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Rule_Park_Slavi(NODE S)
        {
            if(S.VoennaaTematika.FS == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Rule_Gornolijnii_Kurort(NODE S)
        {
            return true;
        }

        public static bool Rule_Poezdka_Na_More(NODE S)
        {
            return true;
        }

        public static bool Rule_Poezdka_Na_Ozero(NODE S)
        {
            return true;
        }

        public static bool Rule_Poezdka_Na_Reku(NODE S)
        {
            return true;
        }

        public static bool Rule_Dayving(NODE S)
        {
            return true;
        }

        public static bool Rule_Alpinizm(NODE S)
        {
            return true;
        }

        public static bool Rule_Excursia_V_Gorod(NODE S)
        {
            return true;
        }

        public static bool Rule_Excursia_V_Sela(NODE S)
        {
            return true;
        }
    }
}
