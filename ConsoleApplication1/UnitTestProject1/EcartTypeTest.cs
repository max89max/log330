using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class EcartTypeTest
    {
        [TestMethod]
        public void TestEcartTypeBorneInferieure()
        {
            const double ecartTypeTest = 10;

            double sommeDistance = 200;
            int nbrPairDonnees = 2;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.AreEqual(ecartType, ecartTypeTest);
        }

        [TestMethod]
        public void TestEcartTypeBorneSuperieure()
        {
            const double ecartTypeTest = 4.47;

            double sommeDistance = 20;
            int nbrPairDonnees = 1;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.AreEqual(Math.Round(ecartType,2), ecartTypeTest);
        }

        [TestMethod]
        public void TestEcartTypeBorneInvalide()
        {
            const double ecartTypeTest = 0;

            double sommeDistance = 230;
            int nbrPairDonnees = 0;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.AreNotEqual(ecartType, ecartTypeTest);
        }
    }
}
