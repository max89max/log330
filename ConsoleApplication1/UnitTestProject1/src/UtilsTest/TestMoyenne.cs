﻿using ConsoleApplication1;
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

            double moyenne = Program.calculMoyenne(listNumber);

            Assert.Equal(moyenne, moyenneTest);
        }

        [Fact]
        public void TestMoyenneBorneSuperieure()
        {
            const double moyenneTest = 20.43;

            List<double> listNumber = new List<double>();

            listNumber.Add(10.9);
            listNumber.Add(20.29);
            listNumber.Add(30.11);

            double moyenne = Program.calculMoyenne(listNumber);

            Assert.Equal(moyenne, moyenneTest);
        }

        [Fact]
        public void TestMoyenneBorneInvalide()
        {
            List<double> listNumber = new List<double>();

            double moyenne = Program.calculMoyenne(listNumber);

            Assert.Equal(double.NaN, moyenne);
        }
    }
}
