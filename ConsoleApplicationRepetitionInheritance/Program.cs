using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Console.WriteLine("--------------------Diesel Bil--------------------------");
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
            Console.WriteLine("--------------------Benzin Bil--------------------------");
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
                Console.WriteLine("Benzinbil. Mærke: {0} Pris: {1} Købsår: {2} \n KmLiter: {3} Registreringsnummer: {4} Halvårigejerafgift: {5} \n Rækkevidde: {6} Lydstyrke: {7}", benzinBil.Mærke, benzinBil.BilPrisExAfgift, benzinBil.KøbsÅr, benzinBil.KmPrLiter, benzinBil.RegistreringsNr, benzinBil.HalvÅrligEjerafgift(), benzinBil.Rækkevidde(), benzinBil.LydStyrke());
            }

            Console.WriteLine("--------------------El Bil--------------------------");
            ElBil elbil01 = new ElBil("Yoga",10000,2016,"EL01",120,20);
            ElBil elbil02 = new ElBil("Ellert",90000,1992,"EL123",20,60);
            ElBil elbil03 = new ElBil("Tesla",720000,2016,"TESLA007",50,42);
            ElBil elbil04 = new ElBil("Bobo", 21000, 2000, "BO09", 10, 20);
            ElBil elbil05 = new ElBil("Jep", 210000, 2014, "J123EP", 30, 22);


            List<ElBil> elbilliste = new List<ElBil>();
            elbilliste.Add(elbil01);
            elbilliste.Add(elbil02);
            elbilliste.Add(elbil03);
            elbilliste.Add(elbil04);
            elbilliste.Add(elbil05);

            foreach (var elBil in elbilliste)
            {
                Console.WriteLine("Elbil. Mærke: {0} Pris: {1} Årgang: {2} \n Regnr: {3} Batteri: {4} KmPrKW: {5} HalvÅrligEjerafgift: {6} \n RegistreringsAfgift: {7} Rækkevidde: {8}", elBil.Mærke, elBil.BilPrisExAfgift,elBil.KøbsÅr,elBil.RegistreringsNr,elBil.BatteriKapacitet,elBil.KmPrKW, elBil.HalvÅrligEjerafgift(),elBil.RegistreringsAfgift(),elBil.Rækkevidde());
            }


            Console.WriteLine("-------------------- Polymorfisme IBIL --------------------------");
            List<IBil> allebilerliste = new List<IBil>();

            allebilerliste.Add(benzbil01);
            allebilerliste.Add(benzbil02);
            allebilerliste.Add(benzbil03);
            allebilerliste.Add(benzbil04);
            allebilerliste.Add(benzbil05);

            allebilerliste.Add(Dbil01);
            allebilerliste.Add(Dbil02);
            allebilerliste.Add(Dbil03);
            allebilerliste.Add(Dbil04);
            allebilerliste.Add(Dbil05);

            allebilerliste.Add(elbil01);
            allebilerliste.Add(elbil02);
            allebilerliste.Add(elbil03);
            allebilerliste.Add(elbil04);
            allebilerliste.Add(elbil05);

            foreach (var bil in allebilerliste)
            {
                if (bil is DieselBil)
                {
                    DieselBil dieselbil = bil as DieselBil;
                    Console.WriteLine("Diesel bil: Registrering nummer: {0} Halvårrigt ejerafgift: {1} Bilensbris med afgift: {2} Rækkevidde: {3} Partikelfilter: {4}", dieselbil.PartikelFilter, dieselbil.RegistreringsNr, dieselbil.HalvÅrligEjerafgift(), dieselbil.TotalPris(), dieselbil.Rækkevidde());
                }
                else if (bil is BenzinBil)
                {
                    BenzinBil benzinbil = bil as BenzinBil;
                    Console.WriteLine("Benzinbil. Mærke: {0} Pris: {1} Købsår: {2} \n KmLiter: {3} Registreringsnummer: {4} Halvårigejerafgift: {5} \n Rækkevidde: {6}", benzinbil.Mærke, benzinbil.BilPrisExAfgift, benzinbil.KøbsÅr, benzinbil.KmPrLiter, benzinbil.RegistreringsNr, benzinbil.HalvÅrligEjerafgift(), benzinbil.Rækkevidde());
                
                }
                else
                {
                    ElBil elbil = bil as ElBil;
                    Console.WriteLine("Elbil. Mærke: {0} Pris: {1} Årgang: {2} \n Regnr: {3} Batteri: {4} KmPrKW: {5} HalvÅrligEjerafgift: {6} \n RegistreringsAfgift: {7} Rækkevidde: {8} Ladetid: {9}", elbil.Mærke, elbil.BilPrisExAfgift, elbil.KøbsÅr, elbil.RegistreringsNr, elbil.BatteriKapacitet, elbil.KmPrKW, elbil.HalvÅrligEjerafgift(), elbil.RegistreringsAfgift(), elbil.Rækkevidde(), elbil.LadeTid());
                
                }
            }
            


            Console.ReadLine();
        }
    }
}
