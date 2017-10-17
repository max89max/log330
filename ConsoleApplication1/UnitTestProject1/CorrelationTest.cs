using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class CorrelationTest
    {
        [TestMethod]
        public void TestCorrelationBorneInferieure()
        {
            const double correlationTest = 200;

            List<double> listNumberX = new List<double>();

            listNumberX.Add(10);
            listNumberX.Add(20);
            listNumberX.Add(30);

            List<double> listNumberY = new List<double>();

            listNumberY.Add(60);
            listNumberY.Add(70);
            listNumberY.Add(90);

            double correlation = CorrelationCalculator.calculCorrelation(listNumberX, listNumberY);

            Assert.AreEqual(correlation, correlationTest);
        }

        [TestMethod]
        public void TestCorrelationBorneSuperieure()
        {
            const double correlationTest = 200;

            List<double> listNumberX = new List<double>();

            listNumberX.Add(0);
            listNumberX.Add(0.01);
            listNumberX.Add(30.5);

            List<double> listNumberY = new List<double>();

            listNumberY.Add(-60);
            listNumberY.Add(-70.99);
            listNumberY.Add(90.74);

            double correlation = CorrelationCalculator.calculCorrelation(listNumberX, listNumberY);

            Assert.AreEqual(correlation, correlationTest);
        }

        [TestMethod]
        public void TestCorrelationBorneInvalide()
        {
            const double correlationTest = 200;

            List<double> listNumberX = new List<double>();

            listNumberX.Add(10);
            listNumberX.Add(20);
            listNumberX.Add(30);
            listNumberX.Add(40);

            List<double> listNumberY = new List<double>();

            listNumberY.Add(60);
            listNumberY.Add(70);
            listNumberY.Add(90);

            double correlation = CorrelationCalculator.calculCorrelation(listNumberX, listNumberY);

            Assert.AreEqual(correlation, correlationTest);
        }
    }
}
