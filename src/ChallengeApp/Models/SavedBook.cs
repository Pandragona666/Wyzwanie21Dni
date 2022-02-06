using System;
using System.IO;

namespace ChallengeApp.Models
{
    public class SavedBook : BookBase
    {
        private const string auditFileName = "audit.txt";

        public override event GradeAddedDelegate GradeAdded;

        public SavedBook(string name) : base(name)
        {
        }

        public override void AddGrade(string grade)
        {
            double parsedGrade = ParsedGrade(grade);

            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(parsedGrade);

                if (GradeAdded != null && parsedGrade <= 3)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

            using (var sw = File.AppendText(auditFileName))
            {
                sw.WriteLine($"{grade}; {DateTime.UtcNow}");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            try
            {
                using (var sw = File.OpenText($"{Name}.txt"))
                {
                    var line = sw.ReadLine();
                    while (line != null)
                    {
                        var number = double.Parse(line);
                        result.Add(number);
                        line = sw.ReadLine();
                    }
                }     
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Nie odnaleziono pliku {Name}.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }
    }
}
