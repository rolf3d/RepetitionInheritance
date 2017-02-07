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

            DieselBil Dbil01 = new DieselBil("VW",50000,2017,16,"A1",true,60);
            DieselBil Dbil02 = new DieselBil("VW",50000,2013,21,"A2",true,50);
            DieselBil Dbil03 = new DieselBil("Opel",100000,2016,24,"B1",true,70);
            DieselBil Dbil04 = new DieselBil("Ford",130000,2013,16,"B2",false,55);
            DieselBil Dbil05 = new DieselBil("Toyota",50000,2012,14,"C1",false,65);

            dieselbilListe.Add(Dbil01);
            dieselbilListe.Add(Dbil02);
            dieselbilListe.Add(Dbil03);
            dieselbilListe.Add(Dbil04);
            dieselbilListe.Add(Dbil05);

            foreach (var biler in dieselbilListe)
            {
                Console.WriteLine("Registrering nummer: {0} Halvårrigt ejerafgift: {1} Bilensbris med afgift: {2} Rækkevidde: {3}", biler.RegistreringsNr, biler.HalvÅrligEjerafgift(), biler.TotalPris(), biler.Rækkevidde());
            }

            BenzinBil benzbil01 = new BenzinBil("Opel",190000,2016,24,"AA12",80);
            BenzinBil benzbil02 = new BenzinBil("Toyota",355000,2014,17,"NN13",76);
            BenzinBil benzbil03 = new BenzinBil("Ford",155000,2012,13,"AS14",60);
            BenzinBil benzbil04 = new BenzinBil("VW",320000,2017,29,"ASD14",40);
            BenzinBil benzbil05 = new BenzinBil("Opel",14500,2010,18,"ADS13",48);

            List<BenzinBil> benzinbilliste = new List<BenzinBil>();
            benzinbilliste.Add(benzbil01);
            benzinbilliste.Add(benzbil02);
            benzinbilliste.Add(benzbil03);
            benzinbilliste.Add(benzbil04);
            benzinbilliste.Add(benzbil05);

            foreach (var benzinBil in benzinbilliste)
            {
                Console.WriteLine("Benzinbil. Mærke: {0} Pris: {1} Købsår: {2} KmLiter: {3} Registreringsnummer: {4} Halvårigejerafgift: {5} Rækkevidde: {6}", benzinBil.Mærke, benzinBil.BilPrisExAfgift, benzinBil.KøbsÅr, benzinBil.KmPrLiter, benzinBil.RegistreringsNr, benzinBil.HalvÅrligEjerafgift(), benzinBil.Rækkevidde());
            }



            Console.ReadLine();
        }
    }
}
