using ChallengeApp.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace Challenge.Tests
{
    public class BookBaseTests
    {
        [Theory]
        [InlineData("6", 6)]
        [InlineData("5-", 4.75)]
        [InlineData("4+", 4.5)]
        public void ParsedGrade_HandedString_ReturnsProperGrade(string input, double expectedResult)
        {
            // arrange
            var bookBase = new BookBaseMock("Test");

            // act
            var result = bookBase.ParsedGrade(input);

            // assert
            Assert.Equal(expectedResult, result);
        }
    }

    public class BookBaseMock : BookBase
    {
        public override event GradeAddedDelegate GradeAdded;

        public BookBaseMock(string name) : base(name)
        {
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
