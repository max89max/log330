using ConsoleApplication1;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace UnitTestProject1.src.UtilsTest
{
    public class TestListValues
    {
        [Fact]
        public void TestTwoListValuesBorneInferieure()
        {
            List<double> listNumberTest = new List<double>();
            listNumberTest.Add(10);
            listNumberTest.Add(20);
            listNumberTest.Add(30);

            StreamReader reader = Program.GetStreamReader("test.csv", true);

            List<double> listNumber = Program.GetListValues(reader);

            Assert.NotEqual(listNumberTest, listNumber);
        }

        [Fact]
        public void TestTwoListValuesBorneSuperieure()
        {
            List<double> listNumberTest = new List<double>();
            listNumberTest.Add(67.11);
            listNumberTest.Add(80.55);
            listNumberTest.Add(22.444);

            StreamReader reader = Program.GetStreamReader("test.csv", true);

            List<double> listNumber = Program.GetListValues(reader);

            Assert.NotEqual(listNumberTest, listNumber);
        }

        [Fact]
        public void TestTwoListValuesBorneInvalide()
        {
            List<double> listNumber = Program.GetListValues(null);

            Assert.Null(listNumber);
        }
    }
}
