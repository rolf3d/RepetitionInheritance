﻿using System;
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
            if (PartikelFilter == false)
            {
                // Hvis partikelfilter ikke findes på bilen, er der en ekstra afgift på 500.
                double ekstra = 500.0;
                return base.HalvÅrligEjerafgift() + ekstra;
                
            }
            return base.HalvÅrligEjerafgift();
        }
    }
}
