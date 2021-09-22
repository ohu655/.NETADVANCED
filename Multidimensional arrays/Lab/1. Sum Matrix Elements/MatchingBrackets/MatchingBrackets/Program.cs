using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indicies = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indicies.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openBracketIndex = indicies.Pop();
                    int closedBracketIndex = i;
                    Console.WriteLine(input.Substring(openBracketIndex, closedBracketIndex - openBracketIndex +1));
                }
            }
        }
    }
}
