using System;
using ConsoleApplication1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject1
{
    public class TestVarianceCalculator
    {
        [Fact]
        public void TestVarianceCalculatorBorneInferieure()
        {
            const double varianceTest = 173.47;

            List<double> listNumber = new List<double>();

            listNumber.Add(450.332342);
            listNumber.Add(25.4554);
            listNumber.Add(232.7777);

            double variance = VarianceCalculator.calculVariance(listNumber);

            Assert.Equal(variance, varianceTest);
        }

        [Fact]
        public void TestVarianceCalculatorBorneSuperieure()
        {
            const double varianceTest = 8.16;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(20);
            listNumber.Add(30);

            double variance = VarianceCalculator.calculVariance(listNumber);

            Assert.Equal(variance, varianceTest);
        }

        [Fact]
        public void TestVarianceCalculatorBorneInvalide()
        {
            double variance = VarianceCalculator.calculVariance(null);

            Assert.Equal(double.NaN, variance);
        }
    }
}
