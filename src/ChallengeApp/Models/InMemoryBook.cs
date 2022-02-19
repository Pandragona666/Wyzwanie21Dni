using System;
using System.Collections.Generic;

namespace ChallengeApp.Models
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class InMemoryBook : BookBase
    {
        public override event GradeAddedDelegate GradeAdded;

        public List<double> grades = new List<double>();

        public Author Author { get; set; }
        public string Genre { get; set; }

        public InMemoryBook(string name, Author author, string genre) : base(name)
        {
            Author = author;
            Genre = genre;
        }

        public override void AddGrade(string grade)
        {
            double parsedGrade = ParsedGrade(grade);

            grades.Add(parsedGrade);

            if (GradeAdded != null && parsedGrade <= 3)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            foreach (double data in grades)
            {
                result.Add(data);
            }

            return result;
        }
    }
}