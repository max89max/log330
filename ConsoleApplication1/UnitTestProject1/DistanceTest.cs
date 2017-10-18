using ConsoleApplication1;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class DistanceTest
    {
        [Test]
        public void TestDistanceBorneInferieure()
        {
            const double distanceTest = 200;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(20);
            listNumber.Add(30);

            double moyenne = 20;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.That(distance, Is.EqualTo(distanceTest));
        }

        [Test]
        public void TestDistanceBorneSuperieure()
        {
            const double distanceTest = 200;

            List<double> listNumber = new List<double>();

            listNumber.Add(10.98);
            listNumber.Add(20.98);
            listNumber.Add(30.98);

            double moyenne = 20.98;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.That(distance, Is.EqualTo(distanceTest));
        }

        [Test]
        public void TestDistanceBorneInvalide()
        {
            const double distanceTest = 20;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(0);
            listNumber.Add(0);

            double moyenne = 0;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.That(distance, Is.EqualTo(distanceTest));
        }
    }
}
