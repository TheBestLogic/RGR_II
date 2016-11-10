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
            bool FirstFlag;
            bool SecondFlag;

            public SUBNODE_ONE SetStructFlag(SUBNODE_ONE Struct)
            {
                this.FirstFlag = Struct.FirstFlag;
                this.SecondFlag = Struct.SecondFlag;
                return this;
            }

            public SUBNODE_ONE Clear()
            {
                this.FirstFlag = false;
                this.SecondFlag = false;
                return this;
            }

            public void Set(bool One = false, bool Two = false)
            {
                this.FirstFlag = (One == true) ? (true) : (false);
                this.SecondFlag = (Two == true) ? (true) : (false);
            }
            
        };

        struct SUBNODE_TWO
        {
            bool FirstFlag;
            bool SecondFlag;
            bool ThirdFlag;

            public SUBNODE_TWO SetStructFlag(SUBNODE_TWO Struct)
            {
                this.FirstFlag = Struct.FirstFlag;
                this.SecondFlag = Struct.SecondFlag;
                this.ThirdFlag = Struct.ThirdFlag;
                return this;
            }

            public SUBNODE_TWO Clear()
            {
                this.FirstFlag = false;
                this.SecondFlag = false;
                this.ThirdFlag = false;
                return this;
            }

            public void Set(bool One = false, bool Two = false, bool Three = false)
            {
                this.FirstFlag = (One == true) ? (true) : (false);
                this.SecondFlag = (Two == true) ? (true) : (false);
                this.ThirdFlag = (Three == true) ? (true) : (false);
            }
        }

        struct NODE
        {
            SUBNODE_ONE AktivniiOtdih;
            SUBNODE_ONE OtdihVKompanii;
            bool Prirodu;
            SUBNODE_ONE Arhitectura;
            SUBNODE_TWO BolshieGoroda;
            SUBNODE_ONE MalenkieGoroda;
            bool Dostoprimechatelnosti;
            SUBNODE_ONE VoennaaTematika;
            SUBNODE_TWO Reki;
            SUBNODE_TWO Gori;
            SUBNODE_TWO SostoanieZdorovia;
            bool OtdihNaPrirode;
            SUBNODE_ONE Temp_Hight;
            SUBNODE_ONE Temp_Low;
            bool Temp_Srednaa;

            public NODE SetStructFlag(NODE Struct)
            {
                this.AktivniiOtdih = Struct.AktivniiOtdih;
                this.OtdihVKompanii = Struct.OtdihVKompanii;
                this.Prirodu = Struct.Prirodu;
                this.Arhitectura = Struct.Arhitectura;
                this.BolshieGoroda = Struct.BolshieGoroda;
                this.MalenkieGoroda = Struct.MalenkieGoroda;
                this.Dostoprimechatelnosti = Struct.Dostoprimechatelnosti;
                this.VoennaaTematika = Struct.VoennaaTematika;
                this.Reki = Struct.Reki;
                this.Gori = Struct.Gori;
                this.SostoanieZdorovia = Struct.SostoanieZdorovia;
                this.OtdihNaPrirode = Struct.OtdihNaPrirode;
                this.Temp_Hight = Struct.Temp_Hight;
                this.Temp_Low = Struct.Temp_Low;
                this.Temp_Srednaa = Struct.Temp_Srednaa;
                return this;
            }

            public NODE Clear()
            {
                this.AktivniiOtdih = this.AktivniiOtdih.Clear();
                this.OtdihVKompanii = this.OtdihVKompanii.Clear();
                this.Prirodu = false;
                this.Arhitectura = this.Arhitectura.Clear();
                this.BolshieGoroda = this.BolshieGoroda.Clear();
                this.MalenkieGoroda = this.MalenkieGoroda.Clear();
                this.Dostoprimechatelnosti = false;
                this.VoennaaTematika = this.VoennaaTematika.Clear();
                this.Reki = this.Reki.Clear();
                this.Gori = this.Gori.Clear();
                this.SostoanieZdorovia = this.SostoanieZdorovia.Clear();
                this.OtdihNaPrirode = false;
                this.Temp_Hight = this.Temp_Hight.Clear();
                this.Temp_Low = this.Temp_Low.Clear();
                this.Temp_Srednaa = false;
                return this;
            }
        };
    }
}
