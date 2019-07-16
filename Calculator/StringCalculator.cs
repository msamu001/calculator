namespace Calculator
{
    public class StringCalculator
    {
        private double ParseCharSymbol(double number1, double number2, char symbol)
        {
            double answer = 0;
            switch (symbol)
            {
                case '/':
                    answer = number1 / number2;
                    break;
                case '*':
                    answer = number1 * number2;
                    break;
                case '+':
                    answer = number1 + number2;
                    break;
                case '-':
                    answer = number1 - number2;
                    break;
            }
            
            return answer;
        }
        public double Calc(string equation)
        {
            var answer = double.Parse(equation.Substring(0,1));
            
            for (var i = 1; i < equation.Length; i += 2)
            {
                var symbol = equation[i];
                var number = double.Parse(equation.Substring(i+1,1));
                answer = ParseCharSymbol(answer, number, symbol);
            }
            
            return answer;
        }
    }
}