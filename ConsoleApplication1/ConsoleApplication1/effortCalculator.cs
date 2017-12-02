using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class EffortCalculator
    {
        public void calcul()
        {
            Console.WriteLine("Bonjour. veuillez entrer le chemin du fichier csv à analyser. Appuyer sur enter en laissant le champ vide pour charger le fichier testEffort.csv dans le dossier bin/Debug");

            StreamReader reader = Program.GetStreamReader("testEffort.csv");

            Tuple<List<double>, List<double>> turpleListNumber = getEffortNoteList(reader);

            List<double> listEffort = turpleListNumber.Item1;
            List<double> listNote = turpleListNumber.Item2;

            double correlation = CorrelationCalculator.calculCorrelation(listEffort, listNote);
            String correlationEffortText = CorrelationCalculator.getNorminalLink(correlation);
        }

        public static Tuple<List<double>, List<double>> getEffortNoteList(StreamReader reader)
        {
            if (reader == null)
                return null;

            List<double> listEffort = new List<double>();
            List<double> listNote = new List<double>();

            string numeroText = " données par colonne : \n";

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split(',');
                if (line.Length == 8)
                {
                    double effort = 0;
                    double note = 0;

                    double.TryParse(line[7], out note);

                    for (int i=1; i<7; i++)
                    {
                        double number = Double.NaN;
                        double.TryParse(line[i], out number);

                        if (!double.IsNaN(number))
                            effort += number;
                    }


                    if(effort != 0)
                        listEffort.Add(effort);

                    if (note != 0)
                        listNote.Add(note);
                    
                    numeroText += "Nom : " + line[0] + " Effort :" + effort + " Note : " + note + "\n";
                }
            }

            Console.WriteLine(numeroText);

            return new Tuple<List<double>, List<double>>(listEffort, listNote);
        }

        public Tuple<List<double>, List<double>> getEffortNoteList(object p)
        {
            throw new NotImplementedException();
        }
    }
}
