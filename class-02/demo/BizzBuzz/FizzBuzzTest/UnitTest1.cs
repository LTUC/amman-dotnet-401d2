using BizzBuzz;

namespace FizzBuzzTest
{
    public class UnitTest1
    {


        [Fact]
        public void ReturnFizzIfDivisibleByThree()
        {

            //Assemble
            int number = 6;

            //Act
            string result = Program.Convert(number);

            //Assert
            Assert.Equal("Fizz", result);


        }

        [Fact]

        public void REturnBuzzIfDivisibleBuFive()
        {
            //Arrange
            int number = 10;

            //Act
            string result = Program.Convert(number);

            //Assert
            Assert.Equal("Buzz", result);
        }


        [Fact]

        public void REturnFizzBuzzIfDivisibleBuFiveAntThree()
        {
            //Arrange
            int number = 15;

            //Act
            string result = Program.Convert(number);

            //Assert
            Assert.Equal("FizzBuzz", result);
        }



        [Fact]
        public void ReturnTheValueIfFour()
        {
            // Arrange
            int number = 4;
            //int number2 = 7;


            string result = Program.Convert(number);

            Assert.Equal(number.ToString(), result);
            Assert.NotEqual("Fizz", result);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(7, "7")]
        [InlineData(11, "11")]
        [InlineData(6, "Fizz")]
        public void ReturnValueIfNither(int numToTest, string expectedValue)
        {
            Assert.Equal(expectedValue, Program.Convert(numToTest));
        }

    }
}