using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)] //Add test data <-------
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(10, 10, 5, 25)]
        [InlineData(12, 12, 12, 36)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = calculator.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(20, 10, 10)]
        [InlineData(10, 10, 0)]
        [InlineData(5, 10, -5)]
        [InlineData(250, 100, 150)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 10, 100)]//Add test data <-------
        [InlineData(5, 5, 25)]
        [InlineData(20, 20, 400)]
        [InlineData(8, 5, 40)]
        [InlineData(5, 12, 60)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 10, 10)]//Add test data <-------
        [InlineData(60, 5, 12)]
        [InlineData(30, 2, 15)]
        [InlineData(42, 7, 6)]
        [InlineData(20, 4, 5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual); 
        }

    }
}
