using ConsoleApplication1;
using System.IO;
using System;
using Xunit;

namespace UnitTestProject
{
    public class EcartTypeTest
    {
        [Fact]
        public void TestEcartTypeBorneInferieure()
        {
            const double ecartTypeTest = 10;

            double sommeDistance = 200;
            int nbrPairDonnees = 2;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.Equal(ecartType, ecartTypeTest);
        }

        [Fact]
        public void TestEcartTypeBorneSuperieure()
        {
            const double ecartTypeTest = 4.47;

            double sommeDistance = 20;
            int nbrPairDonnees = 1;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.Equal(Math.Round(ecartType,2), ecartTypeTest);
        }

        [Fact]
        public void TestEcartTypeBorneInvalide()
        {
            double sommeDistance = double.NaN;
            int nbrPairDonnees =2;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.Equal(double.NaN, ecartType);
        }
    }
}
