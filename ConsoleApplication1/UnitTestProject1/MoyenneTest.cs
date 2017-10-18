using ConsoleApplication1;
using System.IO;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject
{
    public class MoyenneTest
    {
        [Fact]
        public void TestMoyenneBorneInferieure()
        {
            const double moyenneTest = 20;

            List<double> listNumber = new List<double>();

            listNumber.Add(10);
            listNumber.Add(20);
            listNumber.Add(30);

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.Equal(moyenne, moyenneTest);
        }

        [Fact]
        public void TestMoyenneBorneSuperieure()
        {
            const double moyenneTest = 20.999;

            List<double> listNumber = new List<double>();

            listNumber.Add(10.999);
            listNumber.Add(20.999);
            listNumber.Add(30.999);

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.Equal(moyenne, moyenneTest);
        }

        [Fact]
        public void TestMoyenneBorneInvalide()
        {
            const double moyenneTest = 20.999;

            List<double> listNumber = new List<double>();

            double moyenne = VarianceCalculator.GetMoyenne(listNumber);

            Assert.NotEqual(moyenne, moyenneTest);
        }
    }
}
