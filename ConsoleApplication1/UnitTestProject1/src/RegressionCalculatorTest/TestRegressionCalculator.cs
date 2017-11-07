using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using Xunit;

namespace UnitTestProject1.src.RegressionCalculatorTest
{
    public class TestRegressionCalculator
    {
        [Fact]
        public void TestRegressionBorneInferieure()
        {
            List<double> regressionTest = new List<double>();
            regressionTest.Add(-0.8065);
            regressionTest.Add(57.0975);

            List<double> listX = new List<double>();
            listX.Add(5);
            listX.Add(25);
            List<double> listY = new List<double>();
            listY.Add(70);
            listY.Add(20);

            List<double> regression = RegressionCalculator.calculRegression(listX, listY);

            Assert.Equal(regressionTest, regression);
        }

        [Fact]
        public void TestRegressionBorneSuperieure()
        {
            List<double> regressionTest = new List<double>();
            regressionTest.Add(-0.7453);
            regressionTest.Add(57.1394);

            List<double> listX = new List<double>();
            listX.Add(5.777);
            listX.Add(25.33);
            List<double> listY = new List<double>();
            listY.Add(70.11);
            listY.Add(20.99);

            List<double> regression = RegressionCalculator.calculRegression(listX, listY);

            Assert.Equal(regressionTest, regression);
        }

        [Fact]
        public void TestRegressionBorneInvalide()
        {
            List<double> regressionTest = new List<double>();
            regressionTest.Add(double.NaN);
            regressionTest.Add(double.NaN);

            List<double> listX = new List<double>();
            listX.Add(5);
            listX.Add(25);
            List<double> listY = new List<double>();
            listY.Add(20);

            List<double> regression = RegressionCalculator.calculRegression(listX, listY);

            Assert.Null(regression);
        }
    }
}
