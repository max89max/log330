using ConsoleApplication1;
using System.IO;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject
{
    public class DistanceTest
    {
        [Fact]
        public void TestDistanceBorneInferieure()
        {
            const double distanceTest = 200;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(20);
            listNumber.Add(30);

            double moyenne = 20;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.Equal(distance, distanceTest);
        }

        [Fact]
        public void TestDistanceBorneSuperieure()
        {
            const double distanceTest = 190.07;

            List<double> listNumber = new List<double>();

            listNumber.Add(10.98);
            listNumber.Add(20.221);
            listNumber.Add(30.44);

            double moyenne = 20.98;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.Equal(distance, distanceTest);
        }

        [Fact]
        public void TestDistanceBorneInvalide()
        {
            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(double.NaN);
            listNumber.Add(0);

            double moyenne = 50;

            double distance = VarianceCalculator.GetSommeDistance(listNumber, moyenne);

            Assert.Equal(double.NaN, distance);
        }
    }
}
