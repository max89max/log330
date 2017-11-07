using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class RegressionCalculator
    {
        public void calcul()
        {
            Console.WriteLine("Bonjour. veuillez entrer le chemin du fichier csv à analyser. Appuyer sur enter en laissant le champ vide pour charger le fichier testRegression.csv dans le dossier bin/Debug");

            StreamReader reader = Program.GetStreamReader("testRegression.csv");

            Tuple<List<double>, List<double>> turpleListNumber = Program.GetTwoListsValues(reader);

            List<double> listNumberX = turpleListNumber.Item1;
            List<double> listNumberY = turpleListNumber.Item2;

            List<double> correlation = calculRegression(listNumberX, listNumberY);
        }

        public static List<double> calculRegression(List<double> listNumberX, List<double> listNumberY)
        {
            List<double> regressionLineaireB1B0 = new List<double>();

            int nbrPairDonnees = listNumberX.Count;
            double moyenneX = Program.calculMoyenne(listNumberX);
            double moyenneY = Program.calculMoyenne(listNumberY);

            if (nbrPairDonnees != listNumberY.Count)
                return null;

            double b1 = calculB1(listNumberX, listNumberY, moyenneX, moyenneY, nbrPairDonnees);
            double b0 = calculB0(moyenneX, moyenneY, b1);

            regressionLineaireB1B0.Add(b1);
            regressionLineaireB1B0.Add(b0);

            return regressionLineaireB1B0;
        }

        public static double calculB1(List<double> listNumberX, List<double> listNumberY, double moyenneX, double moyenneY, double nbrPairDonnees)
        {
            double b1 = 0;

            double sommeXY = 0;
            double sommePowX = 0;

            Console.WriteLine("     |     x     |     y     |     x*x     |     x*y     |");
            for (int i = 0; i < nbrPairDonnees; i++)
            {
                if (double.IsNaN(listNumberX[i]) || double.IsNaN(listNumberY[i]))
                    return double.NaN;

                double x = listNumberX[i];
                double y = listNumberY[i];
                double xx = Program.pow(x);
                double xy = x * y;

                sommeXY += xy;
                sommePowX += xx;

                Console.WriteLine(" | " + x + " | " + y + " | " + xx + " | " + xy + " | ");
            }

            Console.WriteLine("La moyenne de la liste X est : " + moyenneX);
            Console.WriteLine("La moyenne de la liste X est : " + moyenneY);
            Console.WriteLine("La somme XX est : " + sommePowX);
            Console.WriteLine("La somme XY est : " + sommeXY);

            b1 = (sommeXY - nbrPairDonnees * moyenneX * moyenneY) / (sommePowX - nbrPairDonnees*moyenneX);
            Console.WriteLine("B1 est : " + b1);

            return Math.Round(b1,4);
        }

        public static double calculB0(double moyenneX, double moyenneY, double b1)
        {
            double b0 = 0;

            b0 = moyenneY - b1 * moyenneX;

            Console.WriteLine("B0 est : " + b1);

            return Math.Round(b0,4);
        }
    }
}
