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
        public void ReturnCorrectSymbolAndNumberForOneLineOfInput(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("add 2\napply 3", "3+2")]
        [InlineData("add 2\nmultiply 4\napply 3", "3+2*4")]
        [InlineData("subtract 5\ndivide 3\nadd 4\napply 1", "1-5/3+4")]
        public void ReturnCorrectSymbolAndNumberForMultipleLinesOfInput(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("Add 1", "+1")]
        [InlineData("AdD 2", "+2")]
        [InlineData("adD 3", "+3")]
        public void NotBeCaseSensitive(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }
        
        [Theory]
        [InlineData("Add    1", "+1")]
        [InlineData("   Add  2", "+2")]
        [InlineData("   Add  2 \n    apply  3", "3+2")]
        public void HandleBlankSpace(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);

            result.Should().Be(expectedResult);
        }
    }
}