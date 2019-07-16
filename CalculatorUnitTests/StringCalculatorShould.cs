using Calculator;
using FluentAssertions;
using Xunit;

namespace CalculatorUnitTests
{
    public class StringCalculatorShould
    {
        [Theory]
        [InlineData("1",1)]
        [InlineData("3+2",5)]
        [InlineData("3+2*3",15)]
        [InlineData("9-3/2+8",11)]
        public void ReturnCorrectAnswerToEquation(string equation, double answer)
        {
            var calculator = new StringCalculator();
            
            var result = calculator.Calc(equation);

            result.Should().Be(answer);
        }
    }
}