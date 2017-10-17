using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
