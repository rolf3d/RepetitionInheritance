using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepetitionInheritance
{
    public class DieselBil : Bil
    {
        public bool PartikelFilter { get; set; }
        public DieselBil(string mærke, double bilprisexafgift, double købsår, int kmprliter,string registreringnr, bool partikelFilter) : base(mærke, bilprisexafgift, købsår, kmprliter,registreringnr)
        {
            PartikelFilter = partikelFilter;
        }

        public DieselBil(string mærke,double bilprisexafgift,double købsår,int kmprliter,string registreringnr) : this(mærke,bilprisexafgift,købsår,kmprliter,registreringnr,true)
        {
            
        }

        public override double HalvÅrligEjerafgift()
        {
            if (PartikelFilter == true)
            {
                // Hvis partikelfilter ikke findes på bilen, er der en ekstra afgift på 500.

                if (KmPrLiter < 15)
                {
                    return 2000;
                }
                if (KmPrLiter >= 15 && KmPrLiter <= 25)
                {
                    return 1000;
                }
                if (KmPrLiter > 25)
                {
                    return 350;
                }

            }
            else if (PartikelFilter == false)
            {
                if (KmPrLiter < 15)
                {
                    return 2500;
                }
                if (KmPrLiter >= 15 && KmPrLiter <= 25)
                {
                    return 1500;
                }
                if (KmPrLiter > 25)
                {
                    return 850;
                }
            }
            return 1000;
        }
    }
}
