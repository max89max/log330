using ConsoleApplication1;
using System.IO;
using System;

#if NUNIT
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace UnitTestProject
{
    [TestClass]
    public class NumerateurCorrelationTest
    {
        [TestMethod]
        public void TestNumerateurCorrelationInferieure()
        {
            const double numerateurTest = 200;

            double sommeX = 10;
            double sommeY = 20;
            double sommeXY = 200;
            int nbrPairDonnees = 2;

            double numerateur = CorrelationCalculator.calculNumerateurCorrelation(sommeX, sommeY, sommeXY, nbrPairDonnees);

            Assert.AreEqual(numerateur, numerateurTest);
        }

        [TestMethod]
        public void TestNumerateurCorrelationSuperieure()
        {
            const double numerateurTest = 401.44;

            double sommeX = 10;
            double sommeY = 20;
            double sommeXY = 200.48;
            int nbrPairDonnees = 3;

            double numerateur = CorrelationCalculator.calculNumerateurCorrelation(sommeX, sommeY, sommeXY, nbrPairDonnees);

            Assert.AreEqual(Math.Round(numerateur,2), numerateurTest);
        }

        [TestMethod]
        public void TestNumerateurCorrelationInvalide()
        {
            const double numerateurTest = 0;

            double sommeX = 10;
            double sommeY = 40;
            double sommeXY = 200;
            int nbrPairDonnees = 2;

            double numerateur = CorrelationCalculator.calculNumerateurCorrelation(sommeX, sommeY, sommeXY, nbrPairDonnees);

            Assert.AreEqual(numerateur, numerateurTest);
        }
    }
}
