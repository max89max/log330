using ConsoleApplication1;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class MoyenneTest
    {
        [Test]
        public void TestMoyenneBorneInferieure()
        {
            const double moyenneTest = 20;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(20);
            listNumber.Add(30);

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.That(moyenne, Is.EqualTo(moyenneTest));
        }

        [Test]
        public void TestMoyenneBorneSuperieure()
        {
            const double moyenneTest = 20.999;

            List<double> listNumber = new List<double>();

            listNumber.Add(10.999);
            listNumber.Add(20.999);
            listNumber.Add(30.999);

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.That(moyenne, Is.EqualTo(moyenneTest));
        }

        [Test]
        public void TestMoyenneBorneInvalide()
        {
            const double moyenneTest = 20.999;

            List<double> listNumber = new List<double>();

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.That(moyenne, Is.EqualTo(moyenneTest));
        }
    }
}
