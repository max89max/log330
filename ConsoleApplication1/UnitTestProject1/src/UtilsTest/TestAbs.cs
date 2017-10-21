using ConsoleApplication1;
using System.IO;
using Xunit;

namespace UnitTestProject1
{
    public class TestAbs
    {
        [Fact]
        public void TestAbsBorneInferieure()
        {
            const double absTest = 100;

            double abs = Program.abs(-100);

            Assert.Equal(abs, absTest);
        }

        [Fact]
        public void TestAbsBorneSuperieure()
        {
            const double absTest = 100.90;

            double abs = Program.abs(-100.90);

            Assert.Equal(abs, absTest);
        }

        [Fact]
        public void TestAbsBorneInvalide()
        {
            double abs = Program.abs(double.NaN);

            Assert.Equal(double.NaN, abs);
        }
    }
}
