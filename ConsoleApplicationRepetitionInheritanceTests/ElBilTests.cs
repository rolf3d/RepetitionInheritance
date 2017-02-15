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
    public class ElBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_elbil()
        {
            ElBil Elbil01 = new ElBil("Ellert", 120000, 2016, "El0101", 40000, 12);

            Assert.AreEqual(0, Elbil01.HalvÅrligEjerafgift());
        }

        [TestMethod()]
        public void RækkeviddeTest_10_10()
        {
            ElBil Elbil001 = new ElBil("Ellert", 145000,2016,"323232",10,10);
            Assert.AreEqual(100, Elbil001.Rækkevidde());
     
        }
    }
}