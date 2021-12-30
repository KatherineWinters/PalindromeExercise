using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("flower", false)]
        [InlineData("jeans", false)]
        public void Test1(string word, bool expected)
        {
            
            var wordSmith = new PalindromeExercise.WordSmith();

            var actual = wordSmith.IsAPalidrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
