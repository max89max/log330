using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject1.src.UtilsTest
{
    public class TestEffortNoteList
    {
        [Fact]
        public void TestEffortNoteListBorneInferieure()
        {
            List<double> listNumberTestX = new List<double>();
            listNumberTestX.Add(10);
            listNumberTestX.Add(20);
            listNumberTestX.Add(30);

            List<double> listNumberTestY = new List<double>();
            listNumberTestY.Add(40);
            listNumberTestY.Add(50);
            listNumberTestY.Add(60);

            System.IO.StreamReader reader = Program.GetStreamReader("testEffortInferieur.csv", true);

            Tuple<List<double>, List<double>> turpleListNumber = EffortCalculator.getEffortNoteList(reader);

            Assert.Equal(listNumberTestX, turpleListNumber.Item1);
            Assert.Equal(listNumberTestX, turpleListNumber.Item2);
        }

        [Fact]
        public void TestEffortNoteListBorneSuperieure()
        {
            List<double> listNumberTestX = new List<double>();
            listNumberTestX.Add(10.55);
            listNumberTestX.Add(20.99);
            listNumberTestX.Add(30.11);

            List<double> listNumberTestY = new List<double>();
            listNumberTestY.Add(40.22);
            listNumberTestY.Add(50.66);
            listNumberTestY.Add(60.77);

            System.IO.StreamReader reader = Program.GetStreamReader("testEffortSuperieur.csv", true);

            Tuple<List<double>, List<double>> turpleListNumber = EffortCalculator.getEffortNoteList(reader);

            Assert.Equal(listNumberTestX, turpleListNumber.Item1);
            Assert.Equal(listNumberTestX, turpleListNumber.Item2);
        }

        [Fact]
        public void TestEffortNoteListBorneInvalide()
        {
            Tuple<List<double>, List<double>> turpleListNumber = EffortCalculator.getEffortNoteList(null);

            Assert.Null(turpleListNumber);
        }
    }
}
