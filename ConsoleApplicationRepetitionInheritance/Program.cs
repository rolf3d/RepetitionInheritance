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
            //Bil minbil = new Bil("Ford",200000,2012,18);

            //Console.WriteLine("Total Pris: {0} Afgift: {1} Indkøbspris: {2}", minbil.TotalPris(), minbil.RegistreringsAfgift(), minbil.BilPrisExAfgift);

            List<DieselBil> dieselbilListe = new List<DieselBil>();

            DieselBil Dbil01 = new DieselBil("VW",387000,2017,16,"A1",true);
            DieselBil Dbil02 = new DieselBil("VW",280000,2016,21,"A2",true);
            DieselBil Dbil03 = new DieselBil("Opel",122000,2016,24,"B1",true);
            DieselBil Dbil04 = new DieselBil("Ford",240000,2013,16,"B2",false);
            DieselBil Dbil05 = new DieselBil("Toyota",290000,2012,14,"C1",false);

            dieselbilListe.Add(Dbil01);
            dieselbilListe.Add(Dbil02);
            dieselbilListe.Add(Dbil03);
            dieselbilListe.Add(Dbil04);
            dieselbilListe.Add(Dbil05);

            foreach (var biler in dieselbilListe)
            {
                Console.WriteLine("Registrering nummer: {0} Halvårrigt ejerafgift: {1}", biler.RegistreringsNr, biler.HalvÅrligEjerafgift());
            }


        }
    }
}
