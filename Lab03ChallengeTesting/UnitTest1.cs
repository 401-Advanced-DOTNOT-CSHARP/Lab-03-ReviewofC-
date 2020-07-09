using System;
using Xunit;
using static Lab_03_SystemIO.Program;

namespace Lab03ChallengeTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Return0WhenEnteringTwoNumbers()
        {
            //Arrange
            string words = "4 5";

            //Act
            int results = Challenge1(words);

            //Assert
            Assert.Equal(0, results);
        }
        [Theory]
        [InlineData("4 5 1", 20)]
        [InlineData("4 5 2 9", 40)]
        [InlineData("4 5 cat", 20)]
        [InlineData("dogs are better than cats", 1)]
        [InlineData("10 -5 4", -200)]


        public void TestingChallenge1(string words, int product)
        {
            //Arrange


            //Act
            int results = Challenge1(words);

            //Assert
            Assert.Equal(product, results);
        }
    [Fact]
    public void Challenge2TestAverage()
        {
            int[] numbersArray = new int[] { 5, 4, 8 };
            decimal expected = 5 + 4 + 8;
            decimal average = expected / 3;
            decimal results = Challenge2(numbersArray);
            Assert.Equal(average, results);
        }
        [Fact]
        public void Challenge2ConfirmAverageZero()
        {
            int[] numbersArray = new int[] { 0, 0, 0 };
            decimal expected = 0 + 0 + 0;
            decimal average = expected / 3;
            decimal results = Challenge2(numbersArray);
            Assert.Equal(average, results);
        }
    }
}
