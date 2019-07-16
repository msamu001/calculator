using Calculator;
using Xunit;
using FluentAssertions;

namespace CalculatorUnitTests
{
    public class FileParserShould
    {
        [Theory]
        [InlineData("apply 3","3")]
        [InlineData("apply 7","7")]
        [InlineData("apply 10","10")]
        public void ReturnApplyNumberAsAString(string input, string expectedResult)
        {
            var parser = new FileParser();

            var result = parser.Parse(input);
            
            result.Should().Be(expectedResult);
        }
    }
}