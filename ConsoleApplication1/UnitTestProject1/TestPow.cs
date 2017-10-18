using ConsoleApplication1;
using System.IO;

#if NUNIT
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace UnitTestProject1
{
    [TestClass]
    public class TestPow
    {
        [TestMethod]
        public void TestPowBorneInferieure()
        {
            const double powTest = 100;

            double pow = Program.pow(-10);

            Assert.AreEqual(pow, powTest);
        }

        [TestMethod]
        public void TestPowBorneSuperieure()
        {
            const double powTest = 118.81;

            double pow = Program.pow(-10.90);

            Assert.AreEqual(pow, powTest);
        }

        [TestMethod]
        public void TestPowBorneInvalide()
        {
            const double powTest = 1;

            double pow = Program.pow(-1);

            Assert.AreEqual(pow, powTest);
        }
    }
}
