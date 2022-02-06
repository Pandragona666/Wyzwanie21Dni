using System;
using Xunit;
using ChallengeApp.Models;

namespace Challenge.Tests
{
    public class BookTests
    {
        private const string LowestGrade = "1";
        private const string HighestGrade = "5,25";
        private const string ThirdGrade = "3,5";        

        [Fact]
        public void GetStatistics_ReturnsStats()
        {
            // arrange
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
