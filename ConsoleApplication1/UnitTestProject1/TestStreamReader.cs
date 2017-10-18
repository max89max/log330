using ConsoleApplication1;
using System.IO;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestStreamReader
    {
        [Test]
        public void TestSteamReaderBorneInferieure()
        {
            StreamReader reader = Program.GetStreamReader("test.csv", true);

            Assert.That(reader, !Is.EqualTo(null));
        }

        [Test]
        public void TestSteamReaderBorneSuperieure()
        {
            StreamReader reader = Program.GetStreamReader("test.csv", true);

            Assert.That(reader, !Is.EqualTo(null));
        }

        [Test]
        public void TestSteamReaderBorneInvalide()
        {
            StreamReader reader = Program.GetStreamReader("", true);

            Assert.That(reader, Is.EqualTo(null));
        }
    }
}
