using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepetitionInheritance
{
    public class Bil
    {
        public double BilPrisExAfgift { get; set; }
        public double KøbsÅr { get; set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }
        public double afgift { get; set; }

        public Bil(string mærke,double bilprisexafgift,double købsår,int kmprliter,string registreringnr)
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = bilprisexafgift;
            this.KøbsÅr = købsår;
            this.KmPrLiter = kmprliter;
            this.RegistreringsNr = registreringnr;
        }

        public virtual double RegistreringsAfgift()
        {
            
            if (KøbsÅr <= 2014 && BilPrisExAfgift <= 80500)
            {
                
                return afgift = (BilPrisExAfgift*1.05) - BilPrisExAfgift;
            }
            else if (KøbsÅr >= 2015 && BilPrisExAfgift <= 81700)
            {
                return afgift = (BilPrisExAfgift*1.05) - BilPrisExAfgift;
            }
            else
            {
                return afgift = (BilPrisExAfgift * 1.80) - BilPrisExAfgift;

            }
            
        }

        public virtual double TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        }

        public virtual double HalvÅrligEjerafgift()
        {
            return 1000;
        }
    }
}
