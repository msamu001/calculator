using Calculator;
using Xunit;
using FluentAssertions;

namespace CalculatorUnitTests
{
    public class FileParserShould
    {
        [Theory]
        [InlineData("apply 3", "3")]
        [InlineData("apply 7", "7")]
        [InlineData("apply 10", "10")]
        public void ReturnApplyAndNumberAsAString(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("add 2", "+2")]
        [InlineData("add 20", "+20")]
        public void ReturnAddAndNumberAsCorrectSymbolAndNumberString(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }
        
        [Theory]
        [InlineData("subtract 4", "-4")]
        [InlineData("subtract 44", "-44")]
        public void ReturnSubtractAndNumberAsCorrectSymbolAndNumberString(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }
        
        [Theory]
        [InlineData("divide 6", "/6")]
        [InlineData("divide 12", "/12")]
        public void ReturnDivideAndNumberAsCorrectSymbolAndNumberString(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }
    }
}