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
    public class TestStreamReader
    {
        [TestMethod]
        public void TestSteamReaderBorneInferieure()
        {
            StreamReader reader = Program.GetStreamReader("test.csv", true);

            Assert.AreNotEqual(reader, null);
        }

        [TestMethod]
        public void TestSteamReaderBorneSuperieure()
        {
            StreamReader reader = Program.GetStreamReader("test.csv", true);

            Assert.AreNotEqual(reader, null);
        }

        [TestMethod]
        public void TestSteamReaderBorneInvalide()
        {
            StreamReader reader = Program.GetStreamReader("", true);

            Assert.AreEqual(reader, null);
        }
    }
}
