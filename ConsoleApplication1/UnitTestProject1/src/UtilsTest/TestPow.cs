using ConsoleApplication1;
using System.IO;
using Xunit;

namespace UnitTestProject1
{
    public class TestPow
    {
        [Fact]
        public void TestPowBorneInferieure()
        {
            const double powTest = 100;

            double pow = Program.pow(-10);

            Assert.Equal(pow, powTest);
        }

        [Fact]
        public void TestPowBorneSuperieure()
        {
            const double powTest = 118.81;

            double pow = Program.pow(-10.90);

            Assert.Equal(pow, powTest);
        }

        [Fact]
        public void TestPowBorneInvalide()
        {
            double pow = Program.pow(double.NaN);

            Assert.Equal(double.NaN, pow);
        }
    }
}
