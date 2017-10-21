using ConsoleApplication1;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace UnitTestProject1.src.VarianceCalculatorTest
{
    public class VarianceListValuesTest
    {
        [Fact]
        public void TestVarianceListValuesBorneInferieure()
        {
            List<double> listNumberTest = new List<double>();
            listNumberTest.Add(10);
            listNumberTest.Add(20);
            listNumberTest.Add(30);

            StreamReader reader = Program.GetStreamReader("test.csv", true);

            List<double> listNumber = VarianceCalculator.GetListValues(reader);

            Assert.NotEqual(listNumberTest, listNumber);
        }

        [Fact]
        public void TestVarianceListValuesBorneSuperieure()
        {
            List<double> listNumberTest = new List<double>();
            listNumberTest.Add(67.11);
            listNumberTest.Add(80.55);
            listNumberTest.Add(22.444);

            StreamReader reader = Program.GetStreamReader("test.csv", true);

            List<double> listNumber = VarianceCalculator.GetListValues(reader);

            Assert.NotEqual(listNumberTest, listNumber);
        }

        [Fact]
        public void TestVarianceListValuesBorneInvalide()
        {
            List<double> listNumber = VarianceCalculator.GetListValues(null);

            Assert.Null(listNumber);
        }
    }
}
