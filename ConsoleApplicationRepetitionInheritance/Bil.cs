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
        public int KøbsÅr { get; set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }
        public double afgift { get; set; }

        public virtual double RegistreringsAfgift()
        {
            afgift = 0.0;
            if (KøbsÅr <= 2014 && BilPrisExAfgift >= 80500)
            {
                
                return afgift = (BilPrisExAfgift*1.05) - BilPrisExAfgift;
            }
            else if (KøbsÅr >= 2015 && BilPrisExAfgift >= 81700)
            {
                return afgift = (BilPrisExAfgift*1.05) - afgift;
            }
            else
            {
                return afgift = (BilPrisExAfgift * 1.80) - BilPrisExAfgift;

            }
            
        }

        public virtual double TotalPris()
        {
            return BilPrisExAfgift + afgift;
        }

        public virtual double HalvÅrligEjerafgift()
        {
            return 1000;
        }
    }
}
