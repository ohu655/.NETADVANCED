using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reverseInput = new Stack<char>();

            foreach (char symbol in input)
            {
                reverseInput.Push(symbol);
            }

            while (reverseInput.Count != 0)
            {
                Console.Write(reverseInput.Pop());
            }
        }
    }
}
