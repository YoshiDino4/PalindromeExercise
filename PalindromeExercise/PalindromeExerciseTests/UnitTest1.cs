using System;
using PalindromeExercise; // Ensure you add a reference to the PalindromeExercise project
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]      // Palindrome
        [InlineData("RaceCar", true)]     // Palindrome (case insensitive)
        [InlineData("hello", false)]      // Not a palindrome
        [InlineData("level", true)]       // Palindrome
        [InlineData("Palindrome", false)] // Not a palindrome
        public void IsAPalindrome_Test(string input, bool expected)
        {
            // Arrange
            var wordSmith = new WordSmith();

            // Act
            bool actual = wordSmith.IsAPalindrome(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}