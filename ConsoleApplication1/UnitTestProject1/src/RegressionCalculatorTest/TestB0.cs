using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApplication1;

namespace UnitTestProject1.src.RegressionCalculatorTest
{
    public class TestB0
    {
        [Fact]
        public void TestB0BorneInferieure()
        {
            const double b0Test = 450.0;

            double moyenneX = 300;
            double moyenneY = 600;
            double b1 = 0.5;

            double b0 = RegressionCalculator.calculB0(moyenneX, moyenneY, b1);

            Assert.Equal(b0Test, b0);
        }

        [Fact]
        public void TestB0BorneSuperieure()
        {
            const double b0Test = 447.5;

            double moyenneX = 382.8;
            double moyenneY = 638.9;
            double b1 = 0.5;

            double b0 = RegressionCalculator.calculB0(moyenneX, moyenneY, b1);

            Assert.Equal(b0Test, b0);
        }

        [Fact]
        public void TestB0BorneInvalide()
        {
            double moyenneX = double.NaN;
            double moyenneY = double.NaN;
            double b1 = double.NaN;

            double b0 = RegressionCalculator.calculB0(moyenneX, moyenneY, b1);

            Assert.Equal(double.NaN, b0);
        }
    }
}
