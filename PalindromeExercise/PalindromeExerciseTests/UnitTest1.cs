using System;
using System.Collections.Generic;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("David", false)]
        [InlineData("madam", true)]
        [InlineData("hotdog", false)]
        [InlineData("civic", true)]
        public void IsAPalindrome_Given_Word1_Should_ReturnBool(string word1, bool expected)
        {
            WordSmith challenger = new WordSmith();

            var actual = challenger.IsAPalindrome(word1);

            Assert.Equal(expected, actual);
        }
    }
}
