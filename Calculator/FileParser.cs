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

            foreach (var line in input.Split("\n"))
            {
                var symbol = line.Split(" ")[0];
                var number = line.Split(" ")[1];
            
                if (_SymbolDictionary.ContainsKey(symbol))
                {
                    var symbolValue = _SymbolDictionary[symbol];
                    if (string.IsNullOrEmpty(symbolValue))
                    {
                        output = output.Insert(0, number);
                    }
                    else
                    {
                        output += symbolValue;
                        output += number;
                    }
                }
            }
            
            return output;
        }
    }
}