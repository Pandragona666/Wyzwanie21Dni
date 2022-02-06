using System;
using ChallengeApp.Models;

namespace ChallengeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool correctModuleSwitch = true;
            string title;

            do
            {
                Console.WriteLine($"Wybierz moduł zapisu oceny:");
                Console.WriteLine($"0 - Do pliku");
                Console.WriteLine($"1 - W pamięci");

                switch (Console.ReadLine())
                {
                    case "0":
                        GetBookTitle(out title);
                        var savedBook = new SavedBook(title);
                        AddGradeAndGetStats(savedBook);
                        break;

                    case "1":
                        GetBookTitle(out title);
                        var inMemoryBook = new InMemoryBook(title, new Author("Terry", "Pratchett"), "Fantastyka");
                        AddGradeAndGetStats(inMemoryBook);
                        break;

                    default:
                        Console.WriteLine("Niepoprawny tryb zapisu!");
                        correctModuleSwitch = false;
                        break;
                }
            }
            while (!correctModuleSwitch);
        }

        private static void GetBookTitle(out string title)
        {
            Console.WriteLine($"Wpisz tytuł książki:");
            title = Console.ReadLine();
        }

        private static void AddGradeAndGetStats(IBook book)
        {
            book.GradeAdded += OnGradeAdded;

            EnterGrade(book);

            var stats = book.GetStatistics();

            if(stats.Count != 0)
            {
                Console.WriteLine($"Najniższa ocena: {stats.LowScore:N2}");
                Console.WriteLine($"Najwyzsza ocena: {stats.HighScore:N2}");
                Console.WriteLine($"Średnia ocena: {stats.Average:N2}");
            } 
        }

        private static void EnterGrade(IBook book)
        {
            while (true)
            {
                Console.WriteLine($"Wpisz ocenę książki {book.Name}");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    book.AddGrade(input);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Ocena powinna mieścić się w przedziale 1-6");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Niedopuszczalny format oceny");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Ej! Co tak nisko?!");
        }
    }
}
