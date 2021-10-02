using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbols.ContainsKey(input[i]))
                {
                    symbols.Add(input[i], 1);
                }
                else
                {
                    symbols[input[i]] += 1;
                }
            }

            foreach (var kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
