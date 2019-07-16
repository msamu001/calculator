using Calculator;
using Xunit;
using FluentAssertions;

namespace CalculatorUnitTests
{
    public class FileParserShould
    {
        [Fact]
        public void ParserCanParseApply()
        {
            string input = "apply 3";
            var parser = new FileParser();

            var result = parser.Parse(input);
            
            result.Should().Be("3");
        }
    }
}