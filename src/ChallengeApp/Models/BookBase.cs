using System;

namespace ChallengeApp.Models
{
    public abstract class BookBase : NamedObject, IBook
    {
        public BookBase(string name) : base(name)
        {
        }

        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();

        public abstract event GradeAddedDelegate GradeAdded;

        public double ParsedGrade(string grade)
        {
            switch (grade)
            {
                case "5+":
                    return 5.5;

                case "4+":
                    return 4.5;

                case "3+":
                    return 3.5;

                case "2+":
                    return 2.5;

                case "1+":
                    return 1.5;

                case "6-":
                    return 5.75;

                case "5-":
                    return 4.75;

                case "4-":
                    return 3.75;

                case "3-":
                    return 2.75;

                case "2-":
                    return 1.75;

                default:
                    return CheckIfStringGradeIsWithinBonds(grade);
            }
        }

        private double CheckIfStringGradeIsWithinBonds(string grade)
        {
            double parsedGrade;

            if (double.TryParse(grade, out parsedGrade))
            {
                if (parsedGrade < 1 || parsedGrade > 6)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return parsedGrade;
                }
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}