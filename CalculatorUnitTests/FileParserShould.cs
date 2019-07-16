using Calculator;
using Xunit;
using FluentAssertions;

namespace CalculatorUnitTests
{
    public class FileParserShould
    {
        [Theory]
        [InlineData("apply 3", "3")]
        [InlineData("apply 10", "10")]
        [InlineData("add 2", "+2")]
        [InlineData("add 20", "+20")]
        [InlineData("subtract 4", "-4")]
        [InlineData("subtract 44", "-44")]
        [InlineData("multiply 3", "*3")]
        [InlineData("multiply 27", "*27")]
        public void ReturnOneLineOfInputAsCorrectSymbolAndNumber(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }
    }
}