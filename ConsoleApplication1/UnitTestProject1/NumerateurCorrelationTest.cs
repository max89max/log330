using ConsoleApplication1;
using System.IO;
using System;
using Xunit;

namespace UnitTestProject
{
    public class NumerateurCorrelationTest
    {
        [Fact]
        public void TestNumerateurCorrelationInferieure()
        {
            const double numerateurTest = 200;

            double sommeX = 10;
            double sommeY = 20;
            double sommeXY = 200;
            int nbrPairDonnees = 2;

            double numerateur = CorrelationCalculator.calculNumerateurCorrelation(sommeX, sommeY, sommeXY, nbrPairDonnees);

            Assert.Equal(numerateur, numerateurTest);
        }

        [Fact]
        public void TestNumerateurCorrelationSuperieure()
        {
            const double numerateurTest = 401.44;

            double sommeX = 10;
            double sommeY = 20;
            double sommeXY = 200.48;
            int nbrPairDonnees = 3;

            double numerateur = CorrelationCalculator.calculNumerateurCorrelation(sommeX, sommeY, sommeXY, nbrPairDonnees);

            Assert.Equal(Math.Round(numerateur,2), numerateurTest);
        }

        [Fact]
        public void TestNumerateurCorrelationInvalide()
        {
            const double numerateurTest = 0;

            double sommeX = 10;
            double sommeY = 40;
            double sommeXY = 200;
            int nbrPairDonnees = 2;

            double numerateur = CorrelationCalculator.calculNumerateurCorrelation(sommeX, sommeY, sommeXY, nbrPairDonnees);

            Assert.Equal(numerateur, numerateurTest);
        }
    }
}
