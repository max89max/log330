using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
