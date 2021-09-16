using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i].ToString());
            }

            int prevNumber = int.Parse(stack.Pop());

            while (stack.Count != 0)
            {
                
                string opperand = stack.Pop();

                if (opperand == "+")
                {
                    int currentNum = int.Parse(stack.Pop());
                    prevNumber = currentNum + prevNumber;
                }

                if (opperand == "-")
                {
                    int currentNum = int.Parse(stack.Pop());
                    prevNumber = prevNumber - currentNum;
                }
            }

            Console.WriteLine(prevNumber);
        }
    }
}
