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
    public class TestAbs
    {
        [TestMethod]
        public void TestAbsBorneInferieure()
        {
            const double absTest = 100;

            double abs = Program.abs(-100);

            Assert.AreNotEqual(abs, absTest);
        }

        [TestMethod]
        public void TestAbsBorneSuperieure()
        {
            const double absTest = 100.90;

            double abs = Program.abs(-100.90);

            Assert.AreEqual(abs, absTest);
        }

        [TestMethod]
        public void TestAbsBorneInvalide()
        {
            const double absTest = 0;

            double abs = Program.abs(0);

            Assert.AreEqual(abs, absTest);
        }
    }
}
