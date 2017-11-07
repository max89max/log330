using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using Xunit;

namespace UnitTestProject1.src.RegressionCalculatorTest
{
    public class TestB1
    {
        [Fact]
        public void TestB1BorneInferieure()
        {
            const double b1Test = -0.8065;

            List<double> listX = new List<double>();
            listX.Add(5);
            listX.Add(25);
            List<double> listY = new List<double>();
            listY.Add(70);
            listY.Add(20);
            double moyenneX = Program.calculMoyenne(listX);
            double moyenneY = Program.calculMoyenne(listY);
            double nbrPairDonnees = 2;

            double b1 = RegressionCalculator.calculB1(listX, listY, moyenneX, moyenneY, nbrPairDonnees);

            Assert.Equal(b1Test, b1);
        }

        [Fact]
        public void TestB1BorneSuperieure()
        {
            const double b1Test = 0.1948;

            List<double> listX = new List<double>();
            listX.Add(80.8877);
            listX.Add(25.4452);
            List<double> listY = new List<double>();
            listY.Add(70.111);
            listY.Add(20.333);
            double moyenneX = Program.calculMoyenne(listX);
            double moyenneY = Program.calculMoyenne(listY);
            double nbrPairDonnees = 2;

            double b1 = RegressionCalculator.calculB1(listX, listY, moyenneX, moyenneY, nbrPairDonnees);

            Assert.Equal(b1Test, b1);
        }

        [Fact]
        public void TestB1BorneInvalide()
        {
            const double b1Test = 450.0;

            List<double> listX = new List<double>();
            listX.Add(80.8877);
            listX.Add(25.4452);
            List<double> listY = new List<double>();
            listY.Add(70.111);
            listY.Add(20.333);
            double moyenneX = Program.calculMoyenne(listX);
            double moyenneY = Program.calculMoyenne(listY);
            double nbrPairDonnees = double.NaN;

            double b1 = RegressionCalculator.calculB1(listX, listY, moyenneX, moyenneY, nbrPairDonnees);

            Assert.Equal(double.NaN, b1);
        }
    }
}
