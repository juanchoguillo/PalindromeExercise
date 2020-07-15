using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        //[Fact]
        [Theory]
        [InlineData("juannauj", true)]
        [InlineData("juan", false)]
        [InlineData("racecar", true)]

        public void IsAPolindromeTester(string word, bool expected)
        {
            var tester = new WordSmith();

            var actual = tester.IsAPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
