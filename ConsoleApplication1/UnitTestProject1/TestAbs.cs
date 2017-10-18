using ConsoleApplication1;
using System.IO;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestAbs
    {
        [Test]
        public void TestAbsBorneInferieure()
        {
            const double absTest = 100;

            double abs = Program.abs(-100);

            Assert.That(abs, Is.EqualTo(absTest));
        }

        [Test]
        public void TestAbsBorneSuperieure()
        {
            const double absTest = 100.90;

            double abs = Program.abs(-100.90);

            Assert.That(abs, Is.EqualTo(absTest));
        }

        [Test]
        public void TestAbsBorneInvalide()
        {
            const double absTest = 0;

            double abs = Program.abs(0);

            Assert.That(abs, Is.EqualTo(absTest));
        }
    }
}
