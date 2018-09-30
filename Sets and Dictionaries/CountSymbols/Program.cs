using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var dictOfChars = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (dictOfChars.ContainsKey(symbol) == false)
                {
                    dictOfChars.Add(symbol, 1);
                }
                else
                {
                    dictOfChars[symbol]++;
                }
            }

            foreach (var pair in dictOfChars)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
