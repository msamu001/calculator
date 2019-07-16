namespace Calculator
{
    public class FileParser
    {
        public string Parse(string input)
        {
            var output = "";

            if (input.Contains("apply"))
                output += input.Split(" ")[1];

            return output;
        }
    }
}