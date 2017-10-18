using ConsoleApplication1;
using System.IO;
using Xunit;

namespace UnitTestProject1
{
    public class TestStreamReader
    {
        [Fact]
        public void TestSteamReaderBorneInferieure()
        {
            StreamReader reader = Program.GetStreamReader("test.csv", true);

            Assert.NotEqual(reader, null);
        }

        [Fact]
        public void TestSteamReaderBorneSuperieure()
        {
            StreamReader reader = Program.GetStreamReader("test.csv", true);

            Assert.NotEqual(reader, null);
        }

        [Fact]
        public void TestSteamReaderBorneInvalide()
        {
            StreamReader reader = Program.GetStreamReader("", true);

            Assert.Equal(reader, null);
        }
    }
}
