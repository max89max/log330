using ConsoleApplication1;
using System.IO;
using System.Collections.Generic;

#if NUNIT
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace UnitTestProject
{
    [TestClass]
    public class MoyenneTest
    {
        [TestMethod]
        public void TestMoyenneBorneInferieure()
        {
            const double moyenneTest = 20;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(20);
            listNumber.Add(30);

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.AreEqual(moyenne, moyenneTest);
        }

        [TestMethod]
        public void TestMoyenneBorneSuperieure()
        {
            const double moyenneTest = 20.999;

            List<double> listNumber = new List<double>();

            listNumber.Add(10.999);
            listNumber.Add(20.999);
            listNumber.Add(30.999);

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.AreEqual(moyenne, moyenneTest);
        }

        [TestMethod]
        public void TestMoyenneBorneInvalide()
        {
            const double moyenneTest = 20.999;

            List<double> listNumber = new List<double>();

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.AreNotEqual(moyenne, moyenneTest);
        }
    }
}
