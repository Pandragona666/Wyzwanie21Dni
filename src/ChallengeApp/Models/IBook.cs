namespace ChallengeApp.Models
{
    public interface IBook
    {
        string Name { get; set; }

        void AddGrade(string grade);
        Statistics GetStatistics();

        event GradeAddedDelegate GradeAdded;
    }
}