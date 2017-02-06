﻿using System;
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
        public double afgift105 { get; set; }
        public double afgidt180 { get; set; }

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
            double totalafgift = 0.0;
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift > 80500)
                {
                    afgift105 = (80500  * 1.05);
                    afgidt180 = (BilPrisExAfgift - 80500) * 1.8;
                    totalafgift = afgidt180 + afgift105;
                    return totalafgift - BilPrisExAfgift;
                }
                    return (BilPrisExAfgift * 1.05) - BilPrisExAfgift;
            }
            else if (KøbsÅr > 2015)
            {
                if (BilPrisExAfgift > 81700)
                {
                    afgift105 = (81700*1.05);
                    afgidt180 = (BilPrisExAfgift - 81700)*1.8;
                    totalafgift = afgidt180 + afgift105;
                    return totalafgift - BilPrisExAfgift;
                }
                return (BilPrisExAfgift * 1.05) - BilPrisExAfgift;
            }
            else
            {
                return totalafgift;
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
