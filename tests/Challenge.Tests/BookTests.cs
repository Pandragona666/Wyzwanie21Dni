using Xunit;
using ChallengeApp.Models;
using Challenge.Tests.Attributes;

namespace Challenge.Tests
{
    public class BookTests
    {
        [Fact]
        [UseCulture("pl-PL")]
        public void GetStatistics_ReturnsStats()
        {
            // arrange
            string LowestGrade = "1";
            string HighestGrade = "5,25";
            string ThirdGrade = "3,5";

            var book = new InMemoryBook("Mort", new Author("Terry", "Pratchett"), "Fantastyka");
            book.AddGrade(HighestGrade);
            book.AddGrade(LowestGrade);
            book.AddGrade(ThirdGrade);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(1, result.LowScore);
            Assert.Equal(5.25, result.HighScore);
            Assert.Equal(3.25, result.Average, 1);
            Assert.Equal(3, result.Count);
        }
    }
}
