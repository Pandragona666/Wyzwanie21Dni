using Xunit;
using ChallengeApp.Models;

namespace BookTests;

public class BookTests
{
    private const double LowestRate = 7.9;
    private const double HighestRate = 9.1;
    private const double ThirdRate = 8.7;
    private const double AverageRate = 8.57;

    [Fact]
    public void GetStatistics_ReturnsStats()
    {
        // arrange
        var book = new Book("Mort", new Author("Terry", "Pratchett"), "Fantastyka");
        book.AddRate(HighestRate);
        book.AddRate(LowestRate);
        book.AddRate(ThirdRate);

        // act
        var result = book.GetStatistics();

        // assert
        Assert.Equal(LowestRate, result.LowScore);
        Assert.Equal(HighestRate, result.HighScore);
        Assert.Equal(AverageRate, result.Average, 1);
    }
}