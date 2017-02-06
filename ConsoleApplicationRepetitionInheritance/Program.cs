using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepetitionInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil minbil = new Bil("Ford",200000,2012,18);

            Console.WriteLine("Total Pris: {0} Afgift: {1} Indkøbspris: {2}", minbil.TotalPris(), minbil.RegistreringsAfgift(), minbil.BilPrisExAfgift);
        }
    }
}
