using ConsoleApplication1;
using System.IO;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestPow
    {
        [Test]
        public void TestPowBorneInferieure()
        {
            const double powTest = 100;

            double pow = Program.pow(-10);

            Assert.That(pow, Is.EqualTo(powTest));
        }

        [Test]
        public void TestPowBorneSuperieure()
        {
            const double powTest = 118.81;

            double pow = Program.pow(-10.90);

            Assert.That(pow, Is.EqualTo(powTest));
        }

        [Test]
        public void TestPowBorneInvalide()
        {
            const double powTest = 1;

            double pow = Program.pow(-1);

            Assert.That(pow, Is.EqualTo(powTest));
        }
    }
}
