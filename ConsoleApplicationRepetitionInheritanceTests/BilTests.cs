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
    public class BilTests
    {
        [TestMethod()]
        public void RegistreringsAfgiftTest_Benz_81701_2015()
        {
            //arrange
            BenzinBil bil01 = new BenzinBil("Opel",81701, 2015,20,"Benz01",60);

            //act
            //int totalAfgift = (int)bil01.RegistreringsAfgift();

            //assert
            Assert.AreEqual(85786.8, bil01.RegistreringsAfgift());
        }

        [TestMethod()]
        public void RegistreringsAfgiftTest_Benz_81699_2015()
        {
            //arrange
            BenzinBil bil02 = new BenzinBil("Opel", 81699, 2015, 20, "Benz01", 60);

            //act
            //int totalAfgift = (int)bil01.RegistreringsAfgift();

            //assert
            Assert.AreEqual(85783.95, bil02.RegistreringsAfgift());
        }

        [TestMethod()]
        public void RegistreringsAfgiftTest_Benz_81700_2015()
        {
            //arrange
            BenzinBil bil03 = new BenzinBil("Opel", 81700, 2015, 20, "Benz01", 60);

            //act
            //int totalAfgift = (int)bil01.RegistreringsAfgift();

            //assert
            Assert.AreEqual(85785, bil03.RegistreringsAfgift());
        }

        [TestMethod()]
        public void RegistreringsAfgiftTest_Benz_80500_2014()
        {
            //arrange
            BenzinBil bil04 = new BenzinBil("Opel", 80500, 2014, 20, "Benz01", 60);

            //act
            //int totalAfgift = (int)bil01.RegistreringsAfgift();

            //assert
            Assert.AreEqual(84525, bil04.RegistreringsAfgift());
        }

        [TestMethod()]
        public void RegistreringsAfgiftTest_Benz_80501_2014()
        {
            //arrange
            BenzinBil bil05 = new BenzinBil("Opel", 80501, 2014, 20, "Benz01", 60);

            //act
            //int totalAfgift = (int)bil01.RegistreringsAfgift();

            //assert
            Assert.AreEqual(84526.8, bil05.RegistreringsAfgift());
        }

        [TestMethod()]
        public void RegistreringsAfgiftTest_Benz_80499_2014()
        {
            //arrange
            BenzinBil bil06 = new BenzinBil("Opel", 80499, 2014, 20, "Benz01", 60);

            //act
            //int totalAfgift = (int)bil01.RegistreringsAfgift();

            //assert
            Assert.AreEqual(84523.95, bil06.RegistreringsAfgift());
        }
    }
}