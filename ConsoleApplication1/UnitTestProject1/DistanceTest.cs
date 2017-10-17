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
    public class DistanceTest
    {
        [TestMethod]
        public void TestDistanceBorneInferieure()
        {
            const double distanceTest = 200;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(20);
            listNumber.Add(30);

            double moyenne = 20;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.AreEqual(distance, distanceTest);
        }

        [TestMethod]
        public void TestDistanceBorneSuperieure()
        {
            const double distanceTest = 200;

            List<double> listNumber = new List<double>();

            listNumber.Add(10.98);
            listNumber.Add(20.98);
            listNumber.Add(30.98);

            double moyenne = 20.98;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.AreEqual(distance, distanceTest);
        }

        [TestMethod]
        public void TestDistanceBorneInvalide()
        {
            const double distanceTest = 20;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(0);
            listNumber.Add(0);

            double moyenne = 0;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.AreNotEqual(distance, distanceTest);
        }
    }
}
