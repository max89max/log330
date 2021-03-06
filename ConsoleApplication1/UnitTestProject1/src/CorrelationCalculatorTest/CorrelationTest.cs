﻿using ConsoleApplication1;
using System.IO;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject
{
    public class CorrelationTest
    {
        [Fact]
        public void TestCorrelationBorneInferieure()
        {
            const double correlationTest = 0.98;

            List<double> listNumberX = new List<double>();

            listNumberX.Add(10);
            listNumberX.Add(20);
            listNumberX.Add(30);

            List<double> listNumberY = new List<double>();

            listNumberY.Add(60);
            listNumberY.Add(70);
            listNumberY.Add(90);

            double correlation = CorrelationCalculator.calculCorrelation(listNumberX, listNumberY);

            Assert.Equal(correlation, correlationTest);
        }

        [Fact]
        public void TestCorrelationBorneSuperieure()
        {
            const double correlationTest = 1;

            List<double> listNumberX = new List<double>();

            listNumberX.Add(0);
            listNumberX.Add(0.01);
            listNumberX.Add(30.5);

            List<double> listNumberY = new List<double>();

            listNumberY.Add(-60);
            listNumberY.Add(-70.99);
            listNumberY.Add(90.74);

            double correlation = CorrelationCalculator.calculCorrelation(listNumberX, listNumberY);

            Assert.Equal(correlation, correlationTest);
        }

        [Fact]
        public void TestCorrelationBorneInvalide()
        {
            const double correlationTest = 200;

            List<double> listNumberX = new List<double>();

            listNumberX.Add(double.NaN);
            listNumberX.Add(double.NaN);
            listNumberX.Add(double.NaN);

            List<double> listNumberY = new List<double>();

            listNumberY.Add(double.NaN);
            listNumberY.Add(double.NaN);
            listNumberY.Add(double.NaN);

            double correlation = CorrelationCalculator.calculCorrelation(listNumberX, listNumberY);

            Assert.Equal(double.NaN, correlation);
        }
    }
}
