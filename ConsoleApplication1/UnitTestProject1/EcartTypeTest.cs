using ConsoleApplication1;
using System.IO;
using System;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class EcartTypeTest
    {
        [Test]
        public void TestEcartTypeBorneInferieure()
        {
            const double ecartTypeTest = 10;

            double sommeDistance = 200;
            int nbrPairDonnees = 2;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.That(ecartType, Is.EqualTo(ecartTypeTest));
        }

        [Test]
        public void TestEcartTypeBorneSuperieure()
        {
            const double ecartTypeTest = 4.47;

            double sommeDistance = 20;
            int nbrPairDonnees = 1;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.That(ecartType, Is.EqualTo(ecartTypeTest));
        }

        [Test]
        public void TestEcartTypeBorneInvalide()
        {
            const double ecartTypeTest = 0;

            double sommeDistance = 230;
            int nbrPairDonnees = 0;

            double ecartType = VarianceCalculator.GetEcartType(sommeDistance, nbrPairDonnees);

            Assert.That(ecartType, Is.EqualTo(ecartTypeTest));
        }
    }
}
