using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplicationRepetitionInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRepetitionInheritance.Tests
{
    [TestClass()]
    public class DieselBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerafgiftTestDieselBil_km14()
        {
            DieselBil dieselbil01 = new DieselBil("VW",180000,2015,14,"Diesel0123",true,60);

            Assert.AreEqual(2000,dieselbil01.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTestDieselBil_km17()
        {
            DieselBil dieselbil02 = new DieselBil("VW", 180000, 2015, 17, "Diesel0123", true, 60);

            Assert.AreEqual(1000, dieselbil02.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTestDieselBil_km26()
        {
            DieselBil dieselbil03 = new DieselBil("VW", 180000, 2015, 26, "Diesel0123", true, 60);

            Assert.AreEqual(350, dieselbil03.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTestDieselBil_km14_false()
        {
            DieselBil dieselbil04 = new DieselBil("VW", 180000, 2015, 14, "Diesel0123", false, 60);

            Assert.AreEqual(2500, dieselbil04.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTestDieselBil_km17_false()
        {
            DieselBil dieselbil05 = new DieselBil("VW", 180000, 2015, 17, "Diesel0123", false, 60);
        
            Assert.AreEqual(1500, dieselbil05.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTestDieselBil_km26_false()
        {
            DieselBil dieselbil06 = new DieselBil("VW", 180000, 2015, 26, "Diesel0123", false, 60);

            Assert.AreEqual(850, dieselbil06.HalvÅrligEjerafgift());
        }
    }
}