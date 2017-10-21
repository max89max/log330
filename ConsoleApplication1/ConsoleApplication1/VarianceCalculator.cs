using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class VarianceCalculator
    {
        public void calcul()
        {
            Console.WriteLine("Bonjour. veuillez entrer le chemin du fichier csv à analyser. Appuyer sur enter en laissant le champ vide pour charger le fichier test.csv dans le dossier bin/Debug");

            StreamReader reader = Program.GetStreamReader("test.csv");

            List<double> listNumber = GetListValues(reader);

            double variance = calculVariance(listNumber);

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

        public static double calculVariance(List<double> listNumber)
        {
            if (listNumber == null)
                return double.NaN;

            double moyenne = GetMoyenne(listNumber);
            double sommeDistance = GetSommeDistance(listNumber, moyenne);
            double variance = GetEcartType(sommeDistance, listNumber.Count);

            return variance;
        }
        public static double GetMoyenne(List<double> list)
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

            return Math.Round(moyenne,2);
        }

        public static double GetSommeDistance(List<double> list, double moyenne)
        {
            int ListLength = list.Count;
            double sommeDistance = 0.0;

            if (double.IsNaN(moyenne))
                return double.NaN;

            for (int i = 0; i < ListLength; i++)
            {
                if (double.IsNaN(list[i]))
                    return double.NaN;

                double tempDistance = list[i] - moyenne;
                double distancePow = 0;

                distancePow = Program.pow(tempDistance);

                sommeDistance += distancePow;
            }

            return Math.Round(sommeDistance,2);
        }

        public static double GetEcartType(double sommeDistance, int countList)
        {
            if (double.IsNaN(sommeDistance) || double.IsNaN(countList))
                return double.NaN;

            double variance = (1.0 / countList) * sommeDistance;

            variance = Program.abs(variance);

            Console.WriteLine("Variance : " + variance);

            double ecartType = Math.Sqrt(variance);

            Console.WriteLine("Écart type : " + ecartType);

            return Math.Round(ecartType,2);
        }
    }
}