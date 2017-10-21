﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour \n Que voulez-vous calculer?. (Variance, Correlation)");
            string reponse = Console.ReadLine();

            if(reponse == "Variance")
            {
                VarianceCalculator varianceC = new VarianceCalculator();
                varianceC.calcul();
            }
            else if(reponse == "Correlation")
            {
                CorrelationCalculator correlationC = new CorrelationCalculator();
                correlationC.calcul();
            }

            Console.WriteLine("Appuyer sur enter pour quitter.");
            reponse = Console.ReadLine();
        }

        public static double abs(double value)
        {
            if (double.IsNaN(value))
                return double.NaN;

            double absValue = value;

            if (absValue < 0)
                absValue *= -1;

            return absValue;
        }

        public static double pow(double value)
        {
            if (double.IsNaN(value))
                return double.NaN;

            double absValue = abs(value);

            double powValue = absValue * absValue;

            return powValue;
        }

        public static StreamReader GetStreamReader(String file, bool isTest=false)
        {
            StreamReader reader = null;

            while (reader == null)
            {
                string pathFile = file;

                if (!isTest)
                {
                    pathFile = Console.ReadLine();
                }

                if (pathFile == "")
                {
                    if (file == "")
                        return null;

                    reader = new StreamReader(file);
                }
                else if (!File.Exists(pathFile))
                {
                    Console.WriteLine("Ce fichier n'existe pas. Veillez entrer un fichier valide");
                }
                else if (Path.GetExtension(pathFile) != ".csv")
                {
                    Console.WriteLine("Ce programme ne peut lire que les fichiers csv, veuillez entrer un fichier csv valide");
                }
                else
                {
                    reader = new StreamReader(pathFile);
                } 
            }
            
            return reader;
        }
    }
}
