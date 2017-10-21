using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject1.src.CorrelationCalculatorTest
{
    public class CorrelationListValues
    {
        [Fact]
        public void TestVarianceListValuesBorneInferieure()
        {
            List<double> listNumberTestX = new List<double>();
            listNumberTestX.Add(10);
            listNumberTestX.Add(20);
            listNumberTestX.Add(30);

            List<double> listNumberTestY = new List<double>();
            listNumberTestY.Add(40);
            listNumberTestY.Add(50);
            listNumberTestY.Add(60);

            System.IO.StreamReader reader = Program.GetStreamReader("test.csv", true);

            Tuple<List<double>, List<double>> turpleListNumber = CorrelationCalculator.GetListValues(reader);

            Assert.NotEqual(listNumberTestX, turpleListNumber.Item1);
            Assert.NotEqual(listNumberTestX, turpleListNumber.Item2);
        }

        [Fact]
        public void TestVarianceListValuesBorneSuperieure()
        {
            List<double> listNumberTestX = new List<double>();
            listNumberTestX.Add(10);
            listNumberTestX.Add(20);
            listNumberTestX.Add(30);

            List<double> listNumberTestY = new List<double>();
            listNumberTestY.Add(40);
            listNumberTestY.Add(50);
            listNumberTestY.Add(60);

            System.IO.StreamReader reader = Program.GetStreamReader("test.csv", true);

            Tuple<List<double>, List<double>> turpleListNumber = CorrelationCalculator.GetListValues(reader);

            Assert.NotEqual(listNumberTestX, turpleListNumber.Item1);
            Assert.NotEqual(listNumberTestX, turpleListNumber.Item2);
        }

        [Fact]
        public void TestVarianceListValuesBorneInvalide()
        {
            Tuple<List<double>, List<double>> turpleListNumber = CorrelationCalculator.GetListValues(null);

            Assert.Null(turpleListNumber);
        }
    }
}
