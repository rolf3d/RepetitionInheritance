using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepetitionInheritance
{
    public sealed class BenzinBil : Bil , IbilRadio
    {
        public BenzinBil(string mærke, double bilprisexafgift, double købsår, int kmprliter, string registreringnr,int tank) : base(mærke, bilprisexafgift, købsår, registreringnr)
        {
            this.KmPrLiter = kmprliter;
            this.Tank = tank;
        }

        public override double HalvÅrligEjerafgift()
        {
            if (KmPrLiter <= 20)
            {
                return 1200;
            }
            if (KmPrLiter >20 && KmPrLiter <= 28)
            {
                return 600;
            }
            if (KmPrLiter > 28)
            {
                return 320;
            }
            return 500;
        }

        public override int Rækkevidde()
        {
            return Tank*KmPrLiter;
        }

        public string LydStyrke()
        {
            return  "100 DB";
        }
    }
}
