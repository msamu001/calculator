using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class FileParser
    {
        private Dictionary<string, string> _SymbolDictionary => new Dictionary<string, string>
        {
            {"divide", "/"},
            {"multiply", "*"},
            {"add", "+"},
            {"subtract", "-"},
            {"apply", string.Empty}
        };

        public string Parse(string input)
        {
            var output = "";

            var symbol = input.Split(" ")[0];
            var number = input.Split(" ")[1];
            
            if (_SymbolDictionary.ContainsKey(symbol))
            {
                output += _SymbolDictionary[symbol];
                output += number;
            }
            
            return output;
        }
    }
}