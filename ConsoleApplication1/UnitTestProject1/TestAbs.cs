using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Assert.AreEqual(abs, absTest);
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
