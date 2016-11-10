using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_II.Classes
{
    class ExpertSystemLogic
    {
        struct SUBNODE_ONE
        {
            byte FirstFlag;
            byte SecondFlag;

            public SUBNODE_ONE SetStructFlag(SUBNODE_ONE Struct)
            {
                FirstFlag = Struct.FirstFlag;
                SecondFlag = Struct.SecondFlag;
                return this;
            }

            public SUBNODE_ONE Clear()
            {
                FirstFlag = 0;
                SecondFlag = 0;
                return this;
            }

            public void Set(byte One = 0, byte Two = 0)
            {
                FirstFlag = (One < 0) ? (((One == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
                SecondFlag = (Two < 0) ? (((Two == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
            }
            
        };

        struct SUBNODE_TWO
        {
            byte FirstFlag;
            byte SecondFlag;
            byte ThirdFlag;

            public SUBNODE_TWO SetStructFlag(SUBNODE_TWO Struct)
            {
                FirstFlag = Struct.FirstFlag;
                SecondFlag = Struct.SecondFlag;
                ThirdFlag = Struct.ThirdFlag;
                return this;
            }

            public SUBNODE_TWO Clear()
            {
                FirstFlag = 0;
                SecondFlag = 0;
                ThirdFlag = 0;
                return this;
            }

            public void Set(byte One = 0, byte Two = 0, byte Three = 0)
            {
                FirstFlag = (One < 0) ? (((One == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
                SecondFlag = (Two < 0) ? (((Two == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
                ThirdFlag = (Three < 0) ? (((Three == 1) ? ((byte)1) : ((byte)2))) : ((byte)0);
            }
        }

        public struct NODE
        { 
            SUBNODE_TWO AktivniiOtdih;//3 - byte
            SUBNODE_ONE OtdihVKompanii;//5 - byte
            byte Prirodu;//6 - byte
            byte OtdihNaPrirode;//8 - byte
            SUBNODE_ONE Arhitectura;//11 - byte
            SUBNODE_TWO BolshieGoroda;//13 - byte
            SUBNODE_ONE MalenkieGoroda;//14 - byte
            byte Dostoprimechatelnosti;//16 - byte
            SUBNODE_ONE VoennaaTematika;//19 - byte
            SUBNODE_TWO Reki;//22 - byte
            SUBNODE_TWO Gori;//25 - byte
            SUBNODE_TWO SostoanieZdorovia;//28 - byte
            SUBNODE_ONE Temp_Hight;//30 - byte
            SUBNODE_ONE Temp_Low;//32 - byte
            byte Temp_Srednaa;//33 - byte
            /*
             * SUBNODE_ONE AktivniiOtdih;               -Активный Отдых
             *                      byte FirstFlag;     ---Предпочитает активный отдых
             *                      byte SecondFlag;    ---Любит смену обстановки
             *                      byte ThirdFlag;     ---Экстримальный отдых
             * SUBNODE_ONE OtdihVKompanii;              -Отдых в компании
             *                      byte FirstFlag;     ---Большая компания
             *                      byte SecondFlag;    ---Маленькая компания
             * byte Prirodu;                            -Любит природу
             * byte OtdihNaPrirode;                     -Любит отдых на природе
             * SUBNODE_ONE Arhitectura;                 -Любит архитектуру
             *                      byte FirstFlag;     ---Исторические строения
             *                      byte SecondFlag;    ---Современные строения
             * SUBNODE_TWO BolshieGoroda;               -Любит большие города
             *                      byte FirstFlag;     ---Промышленные города
             *                      byte SecondFlag;    ---Столицы
             *                      byte ThirdFlag;     ---Обласные центры
             * SUBNODE_ONE MalenkieGoroda;              -Любит маленькие города
             *                      byte FirstFlag;     ---Провинцыальные города
             *                      byte SecondFlag;    ---Села
             * byte Dostoprimechatelnosti;              -Любит достопримечательности
             * SUBNODE_ONE VoennaaTematika;             -Любит военную тематику
             *                      byte FirstFlag;     ---Парки военной техники
             *                      byte SecondFlag;    ---Музеи славы
             * SUBNODE_TWO Reki;                        -Любит реки
             *                      byte FirstFlag;     ---Моря
             *                      byte SecondFlag;    ---Реки
             *                      byte ThirdFlag;     ---Озера
             * SUBNODE_TWO Gori;                        -Любит горы
             *                      byte FirstFlag;     ---Высокие горы
             *                      byte SecondFlag;    ---холмы
             *                      byte ThirdFlag;     ---с возможностью подьёма
             * SUBNODE_TWO SostoanieZdorovia;           -Состояние здоровья
             *                      byte FirstFlag;     ---Хорошее
             *                      byte SecondFlag;    ---Среднее
             *                      byte ThirdFlag;     ---Тяжелое
             * SUBNODE_ONE Temp_Hight;                  -Любит высокую температуру
             *                      byte FirstFlag;     --- 30+
             *                      byte SecondFlag;    --- 25+ - 30+
             * SUBNODE_ONE Temp_Low;                    -Любит низкую температуру
             *                      byte FirstFlag;     --- -10 - 15+
             *                      byte SecondFlag;    --- -30 - -10
             * byte Temp_Srednaa;                       -Любит среднюю температуру
             */
            public NODE SetStructFlag(NODE Struct)
            {
                AktivniiOtdih = Struct.AktivniiOtdih;
                OtdihVKompanii = Struct.OtdihVKompanii;
                Prirodu = Struct.Prirodu;
                Arhitectura = Struct.Arhitectura;
                BolshieGoroda = Struct.BolshieGoroda;
                MalenkieGoroda = Struct.MalenkieGoroda;
                Dostoprimechatelnosti = Struct.Dostoprimechatelnosti;
                VoennaaTematika = Struct.VoennaaTematika;
                Reki = Struct.Reki;
                Gori = Struct.Gori;
                SostoanieZdorovia = Struct.SostoanieZdorovia;
                OtdihNaPrirode = Struct.OtdihNaPrirode;
                Temp_Hight = Struct.Temp_Hight;
                Temp_Low = Struct.Temp_Low;
                Temp_Srednaa = Struct.Temp_Srednaa;
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

        public static bool Rule_Sanatorii_V_Gorah(NODE Struct)
        {
            if ()
            {

            }
            return true;
        }

        public static bool Rule_Sanatorii_U_Reki(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Sanatorii(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Otdih_V_Palatkah(NODE Struct)
        {
            return true;
        }

        public static bool RuleSanatoriiVGorah(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Voennii_Muzei(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Park_Slavi(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Gornolijnii_Kurort(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Poezdka_Na_More(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Poezdka_Na_Ozero(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Poezdka_Na_Reku(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Dayving(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Alpinizm(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Excursia_V_Gorod(NODE Struct)
        {
            return true;
        }

        public static bool Rule_Excursia_V_Sela(NODE Struct)
        {
            return true;
        }
    }
}
