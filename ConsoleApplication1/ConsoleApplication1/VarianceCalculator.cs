using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class VarianceCalculator
    {
        public void calcul()
        {
            Console.WriteLine("Bonjour. veuillez entrer le chemin du fichier csv à analyser. Appuyer sur enter en laissant le champ vide pour charger le fichier test.csv dans le dossier bin/Debug");

            List<int> listNumber = new List<int>();
            string numeroText = "données : ";

            StreamReader reader = Program.GetStreamReader("test.csv");

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                listNumber.Add(Int32.Parse(line));
                numeroText += line + ", ";

            }

            numeroText = listNumber.Count + " " + numeroText;

            Console.WriteLine(numeroText);

            double moyenne = GetMoyenne(listNumber);
            double sommeDistance = GetSommeDistance(listNumber, moyenne);
            double variance = GetEcartType(sommeDistance, listNumber.Count);
        }

        static double GetMoyenne(List<int> list)
        {
            double moyenne = 0;
            int ListLength = list.Count;
            for (int i = 0; i < ListLength; i++)
            {
                moyenne += list[i];
            }

            moyenne /= ListLength;

            Console.WriteLine("Moyenne : " + moyenne);

            return moyenne;
        }

        static double GetSommeDistance(List<int> list, double moyenne)
        {
            int ListLength = list.Count;
            double sommeDistance = 0.0;
            for (int i = 0; i < ListLength; i++)
            {
                double tempDistance = list[i] - moyenne;
                double distancePow = 0;

                distancePow = Program.pow(tempDistance);

                sommeDistance += distancePow;
            }

            return sommeDistance;
        }

        static double GetEcartType(double sommeDistance, int countList)
        {
            double variance = (1.0 / countList) * sommeDistance;

            variance = Program.abs(variance);

            Console.WriteLine("Variance : " + variance);

            double ecartType = Math.Sqrt(variance);

            Console.WriteLine("Écart type : " + ecartType);

            return ecartType;
        }
    }
}