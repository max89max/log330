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
            const double absTest = 0;

            double abs = Program.abs(0);

            Assert.Equal(abs, absTest);
        }
    }
}
