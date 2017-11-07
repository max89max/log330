using System;
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
            Console.WriteLine("Bonjour \n Que voulez-vous calculer?. (Variance, Correlation, Regression)");
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
            else if (reponse == "Regression")
            {
                RegressionCalculator regressionC = new RegressionCalculator();
                regressionC.calcul();
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

        public static double calculMoyenne(List<double> list)
        {
            double moyenne = 0;
            int ListLength = list.Count;
            for (int i = 0; i < ListLength; i++)
            {
                if (double.IsNaN(list[i]))
                    return double.NaN;

                moyenne += list[i];
            }

            moyenne /= ListLength;

            Console.WriteLine("Moyenne : " + moyenne);

            return Math.Round(moyenne, 2);
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

        public static List<double> GetListValues(StreamReader reader)
        {
            if (reader == null)
                return null;

            string numeroText = "données : ";
            List<double> listNumber = new List<double>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                listNumber.Add(Int32.Parse(line));
                numeroText += line + ", ";

            }

            numeroText = listNumber.Count + " " + numeroText;

            Console.WriteLine(numeroText);

            return listNumber;
        }

        public static Tuple<List<double>, List<double>> GetTwoListsValues(StreamReader reader)
        {
            if (reader == null)
                return null;

            List<double> listNumberX = new List<double>();
            List<double> listNumberY = new List<double>();

            string numeroText = " données par colonne : \n";

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split(',');
                if (line.Length == 2)
                {
                    var lineX = line[0].Split(';');
                    var lineY = line[1].Split(';');

                    var numberX = lineX[0];
                    var numberY = lineY[0];

                    if (lineX.Length == 2)
                        numberX += "," + lineX[1];


                    if (lineY.Length == 2)
                        numberY += "," + lineY[1];

                    listNumberX.Add(Convert.ToDouble(numberX));
                    listNumberY.Add(Convert.ToDouble(numberY));

                    numeroText += numberX + " " + numberY + "\n";
                }
            }

            numeroText = listNumberX.Count + numeroText;

            Console.WriteLine(numeroText);

            return new Tuple<List<double>, List<double>>(listNumberX, listNumberY); ;
        }
    }
}
