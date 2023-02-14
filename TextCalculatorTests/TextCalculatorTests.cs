using System;
using Xunit;
using TaskOne;

namespace Tests
{
    public class TextCalculatorTests
    {

        TextCalculator calculator = new TextCalculator();
        // RETURNS SUM

        [Fact]
        public void Add_OneNumber()
        {
            // Arrange
            
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

            string input = "1,2";
            string expectedResult = "3";

            string result = calculator.Add(input);

            Assert.Equal(expectedResult, result);

        }
        [Fact]
        public void Add_ManyNumbers()
        {

            string input = "1,2,3,4,5";
            string expectedResult = "15";

            string result = calculator.Add(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Add_DecimalNumber()
        {

            string input = "1, 2, 9.2, 2.3";
            string expectedResult = "14.5";

            string result = calculator.Add(input);

            Assert.Equal(expectedResult, result);
        }
        // RETURNS ZERO

        [Fact]
        public void Add_EmptyString()
        {

            string input = "";
            string expectedResult = "0";

            string result = calculator.Add(input);

            Assert.Equal(expectedResult, result);
        }

        // THROWS EXCEPTION

        [Fact]
        public void Add_NegativeNumbers()
        {

            string input = "-1,2,-3";

            var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(input));

            Assert.Equal("Negative numbers not allowed: -1, -3", exception.Message);
        }

        [Fact]
        public void Add_MissingNumberInLastPosition()
        {

            string input = "1,2,";

            var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(input));

            Assert.Equal("Missing number in last position.", exception.Message);
        }

        [Fact]
        public void Add_NotDigits()
        {

            string input = "1, 2, three, ]";

            var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(input));
            Assert.Equal("Input must contain only digits.", exception.Message);
        }

        


    }
}
