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
    public class BenzinBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_benzinbil_20()
        {
            BenzinBil benzbil_01 = new BenzinBil("Toyota",155000,2002,20,"T0120",45);

            Assert.AreEqual(1200, benzbil_01.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_benzinbil_24()
        {
            BenzinBil benzbil_02 = new BenzinBil("Toyota", 155000, 2002, 24, "T0120", 45);

            Assert.AreEqual(600, benzbil_02.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_benzinbil_29()
        {
            BenzinBil benzbil_03 = new BenzinBil("Toyota", 155000, 2002, 29, "T0120", 45);

            Assert.AreEqual(320, benzbil_03.HalvÅrligEjerafgift());
        }
    }
}