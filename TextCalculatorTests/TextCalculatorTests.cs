using System;
using Xunit;
using TaskOne;

namespace Tests
{
    public class TextCalculatorTests
    {
        // RETURNS SUM

        [Fact]
        public void Add_OneNumber()
        {
            // Arrange
            TextCalculator calculator = new TextCalculator();
            string input = "3";
            string expectedResult = "3";

            // Act
            string result = calculator.Add(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Add_TwoNumbers()
        {

            TextCalculator calculator = new TextCalculator();
            string input = "1,2";
            string expectedResult = "3";

            string result = calculator.Add(input);

            Assert.Equal(expectedResult, result);

        }
        [Fact]
        public void Add_ManyNumbers()
        {

            TextCalculator calculator = new TextCalculator();
            string input = "1,2,3,4,5";
            string expectedResult = "15";

            string result = calculator.Add(input);

            Assert.Equal(expectedResult, result);
        }

        // RETURNS ZERO

        [Fact]
        public void Add_EmptyString()
        {

            TextCalculator calculator = new TextCalculator();
            string input = "";
            string expectedResult = "0";

            string result = calculator.Add(input);

            Assert.Equal(expectedResult, result);
        }

        // THROWS EXCEPTION

        [Fact]
        public void Add_NegativeNumbers()
        {

            TextCalculator calculator = new TextCalculator();
            string input = "-1,2,-3";

            var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(input));

            Assert.Equal("Negative numbers not allowed: -1, -3", exception.Message);
        }

        [Fact]
        public void Add_MissingNumberInLastPosition()
        {

            TextCalculator calculator = new TextCalculator();
            string input = "1,2,";

            var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(input));

            Assert.Equal("Missing number in last position.", exception.Message);
        }

        [Fact]
        public void Add_NotDigits()
        {
            
            TextCalculator calculator = new TextCalculator();
            string input = "1, 2, three, ]";

            var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(input));
            Assert.Equal("Input must contain only digits.", exception.Message);
        }



    }
}
