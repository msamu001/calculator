using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class FileParser
    {
        private Dictionary<string, string> symbolDictionary => new Dictionary<string, string>
        {
            {"add", "+"},
            {"subtract", "-"},
            {"divide", "/"},
            {"apply", string.Empty}
        };

        public string Parse(string input)
        {
            var output = "";

            var symbol = input.Split(" ")[0];
            var number = input.Split(" ")[1];
            
            if (symbolDictionary.ContainsKey(symbol))
            {
                output += symbolDictionary[symbol];
                output += number;
            }
            
            return output;
        }
    }
}