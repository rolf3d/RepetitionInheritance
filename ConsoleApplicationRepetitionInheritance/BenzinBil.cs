﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepetitionInheritance
{
    public sealed class BenzinBil : Bil
    {
        public BenzinBil(string mærke, double bilprisexafgift, double købsår, int kmprliter, string registreringnr) : base(mærke, bilprisexafgift, købsår, kmprliter, registreringnr)
        {
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
    }
}