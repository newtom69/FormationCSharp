using System;
using System.Diagnostics;
using MesOperationsArithmetiques;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MesOperationsArtithmetiquesTU
{
    [TestClass]
    public class DiviserTU
    {
        [TestMethod]
        public void TestDivisionCasParDefaut()
        {
            Calculator calc = new Calculator();
            decimal result = calc.Diviser(4, 2);
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void TestDivisionPar1()
        {
            Calculator calc = new Calculator();
            decimal result = calc.Diviser(4, 1);
            Assert.IsTrue(result == 4);
        }

        [TestMethod]
        public void TestDivisionParMemeNombre()
        {
            Calculator calc = new Calculator();
            int nombre1 = 7;
            decimal result = calc.Diviser(nombre1, nombre1);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void TestDivisionSigneDifferent()
        {
            Calculator calc = new Calculator();
            int nombre1 = 7;
            decimal result = calc.Diviser(nombre1, 0-nombre1);
            Assert.IsTrue(result<0);
        }

        [TestMethod]
        public void TestDivisionPar0()
        {
            Calculator calc = new Calculator();

            Assert.ThrowsException<DivideByZeroException>( () =>
            {
                decimal resultat = calc.Diviser(4, 0);
            });

        }
    }
}
