using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepetitionInheritance
{
    public class ElBil : Bil , IeLMotor
    {
        public int BatteriKapacitet { get; set; }
        public int KmPrKW { get; set; }

        public ElBil(string mærke, double bilprisexafgift, double købsår, string registreringnr, int batterikapacitet,int kmprkw) : base(mærke, bilprisexafgift, købsår, registreringnr)
        {
            this.BatteriKapacitet = batterikapacitet;
            this.KmPrKW = kmprkw;
        }

        

        public override double HalvÅrligEjerafgift()
        {
            return 0;
        }

        public override double RegistreringsAfgift()
        {
            double totalafgift;
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift >= 80500)
                {
                    afgift105 = (80500 * 1.05);
                    afgidt180 = (BilPrisExAfgift - 80500) * 1.8;
                    totalafgift = afgidt180 + afgift105;
                    return (totalafgift)* 0.2;
                }
                return ((BilPrisExAfgift * 1.05)) * 0.2;
            }
            else if (KøbsÅr >= 2015)
            {
                if (BilPrisExAfgift > 81700)
                {
                    afgift105 = (81700 * 1.05);
                    afgidt180 = (BilPrisExAfgift - 81700) * 1.8;
                    totalafgift = afgidt180 + afgift105;
                    return (totalafgift) * 0.2;
                }
                return ((BilPrisExAfgift * 1.05)) * 0.2;
            }

            else
            {
                return BilPrisExAfgift;
            }
        }

        public override int Rækkevidde()
        {
            return BatteriKapacitet*KmPrKW;
        }

        //public int ladetid { get; set; }
        public int LadeTid()
        {
           
            return 5;
        }
    }
}
