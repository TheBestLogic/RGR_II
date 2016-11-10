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

        struct NODE
        {
            SUBNODE_ONE AktivniiOtdih;
            SUBNODE_ONE OtdihVKompanii;
            byte Prirodu;
            SUBNODE_ONE Arhitectura;
            SUBNODE_TWO BolshieGoroda;
            SUBNODE_ONE MalenkieGoroda;
            byte Dostoprimechatelnosti;
            SUBNODE_ONE VoennaaTematika;
            SUBNODE_TWO Reki;
            SUBNODE_TWO Gori;
            SUBNODE_TWO SostoanieZdorovia;
            byte OtdihNaPrirode;
            SUBNODE_ONE Temp_Hight;
            SUBNODE_ONE Temp_Low;
            byte Temp_Srednaa;

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
    }
}
