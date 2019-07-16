using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
                var splitInput = Regex.Split(line, @"\s+").Where(s => s != string.Empty).ToArray();
                var symbol = splitInput[0].ToLower();
                var number = splitInput[1];

                if (!_SymbolDictionary.ContainsKey(symbol)) continue;
                
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
            
            return output;
        }
    }
}