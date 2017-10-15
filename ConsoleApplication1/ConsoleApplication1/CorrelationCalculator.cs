using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class CorrelationCalculator
    {
        public void calcul()
        {
            Console.WriteLine("Bonjour. veuillez entrer le chemin du fichier csv à analyser. Appuyer sur enter en laissant le champ vide pour charger le fichier testCorrelation.csv dans le dossier bin/Debug");

            List<double> listNumberX = new List<double>();
            List<double> listNumberY = new List<double>();
            string numeroText = " données par colonne : \n";

            StreamReader reader = Program.GetStreamReader("testCorrelation.csv");

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split(',');
                if(line.Length == 2)
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

            double correlation = calculCorrelation(listNumberX, listNumberY);

            string correlationText = "La valeur nominale du lien de la corrélation de " + correlation + " est de";

            if (correlation < 0.2)
            {
                correlationText += " nulle à faible";
            }
            else if (correlation < 0.4)
            {
                correlationText += " faible à moyenne";
            }
            else if (correlation < 0.6)
            {
                correlationText += " moyenne à forte";
            }
            else if (correlation < 0.8)
            {
                correlationText += " forte à très forte";
            }
            else if (correlation <= 1)
            {
                correlationText += " très forte à parfaite";
            }

            Console.WriteLine(correlationText);
        }

        static double calculCorrelation(List<double> listX, List<double> listY)
        {
            double correlation = 0;
            int nbrPairDonnees = listX.Count;

            double sommeX = 0;
            double sommeY = 0;

            double sommeXY = 0;

            double sommeExposantX = 0;
            double sommeExposantY = 0;

            Console.WriteLine("     |     x     |     y     |     x*x     |     x*y     |     y*y     |     ");
            for (int i = 0; i < nbrPairDonnees; i++)
            {
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

            return Program.abs(correlation);
        }

        static double calculNumerateurCorrelation(double sommeX, double sommeY, double sommeXY, int nbrElement)
        {
            double numerateur = (nbrElement * (sommeXY) - (sommeX * sommeY));

            return numerateur;
        }

        static double calculDenominateurCorrelation(double sommeExposantX, double sommeExposantY, double sommeXPow, double sommeYPow, int nbrElement)
        {
            double denominateur = ((nbrElement * (sommeExposantX) - sommeXPow) * (nbrElement * (sommeExposantY) - sommeYPow));

            return denominateur;
        }
    }
}