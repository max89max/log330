using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CorrelationCalculator
    {
        public void calcul()
        {
            Console.WriteLine("Bonjour. veuillez entrer le chemin du fichier csv à analyser. Appuyer sur enter en laissant le champ vide pour charger le fichier testCorrelation.csv dans le dossier bin/Debug");

            StreamReader reader = Program.GetStreamReader("testCorrelation.csv");

            Tuple<List<double>, List<double>> turpleListNumber = GetListValues(reader);

            List<double> listNumberX = turpleListNumber.Item1;
            List<double> listNumberY = turpleListNumber.Item2;

            double correlation = calculCorrelation(listNumberX, listNumberY);
        }

        public static Tuple<List<double>, List<double>> GetListValues(StreamReader reader)
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

        public static double calculCorrelation(List<double> listX, List<double> listY)
        {
            double correlation = 0;
            int nbrPairDonnees = listX.Count;

            if (nbrPairDonnees != listY.Count)
                return double.NaN;

            double sommeX = 0;
            double sommeY = 0;

            double sommeXY = 0;

            double sommeExposantX = 0;
            double sommeExposantY = 0;

            Console.WriteLine("     |     x     |     y     |     x*x     |     x*y     |     y*y     |     ");
            for (int i = 0; i < nbrPairDonnees; i++)
            {
                if (double.IsNaN(listX[i]) || double.IsNaN(listY[i]))
                    return double.NaN;

                double x = listX[i];
                double y = listY[i];
                double xy = x*y;
                double xx = Program.pow(x);
                double yy = Program.pow(y);

                Console.WriteLine(" | "+ x + " | " + y + " | " + xx + " | " + xy + " | " + yy + " | ");

                sommeX += x;
                sommeY += y;
                sommeXY += xy;
                sommeExposantX += xx;
                sommeExposantY += yy;
            }

            double sommeXPow = Program.pow(sommeX);
            double sommeYPow = Program.pow(sommeY);

            double numerateur = calculNumerateurCorrelation(sommeX, sommeY, sommeXY, nbrPairDonnees);
            double denominateur = calculDenominateurCorrelation(sommeExposantX, sommeExposantY, sommeXPow, sommeYPow, nbrPairDonnees);

            correlation = numerateur / Math.Sqrt(denominateur);

            return Math.Round(Program.abs(correlation),2);
        }

        public static double calculNumerateurCorrelation(double sommeX, double sommeY, double sommeXY, int nbrElement)
        {
            if (double.IsNaN(sommeX) || double.IsNaN(sommeY) || double.IsNaN(sommeXY) || double.IsNaN(nbrElement))
                return double.NaN;

            double numerateur = (nbrElement * (sommeXY) - (sommeX * sommeY));

            return numerateur;
        }

        public static double calculDenominateurCorrelation(double sommeExposantX, double sommeExposantY, double sommeXPow, double sommeYPow, int nbrElement)
        {
            if (double.IsNaN(sommeExposantX) || double.IsNaN(sommeExposantY) || double.IsNaN(sommeXPow) || double.IsNaN(sommeYPow) || double.IsNaN(nbrElement))
                return double.NaN;

            double denominateur = ((nbrElement * (sommeExposantX) - sommeXPow) * (nbrElement * (sommeExposantY) - sommeYPow));

            return denominateur;
        }

        public static String getNorminalLink(double correlation)
        {
            string correlationText = "La valeur nominale du lien de la corrélation de " + correlation + " est de";
            string norminalLink = "nulle";

            if(correlation > 0 && correlation <= 1)
            {
                if (correlation < 0.2)
                {
                    norminalLink = " nulle à faible";
                }
                else if (correlation < 0.4)
                {
                    norminalLink = " faible à moyenne";
                }
                else if (correlation < 0.6)
                {
                    norminalLink = " moyenne à forte";
                }
                else if (correlation < 0.8)
                {
                    norminalLink = " forte à très forte";
                }
                else if (correlation <= 1)
                {
                    norminalLink = " très forte à parfaite";
                }
            }
            
            Console.WriteLine(correlationText + norminalLink);

            return norminalLink;
        }
    }
}