using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = numbers[0];
            int numbersToPop = numbers[1];
            int numberToPeek = numbers[2];

            int[] numbersInStack = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                int currentNumber = numbersInStack[i];
                stack.Push(currentNumber);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            int smallestNumber = int.MaxValue;

            while (stack.Any())
            {
                if (stack.Peek() == numberToPeek)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    int number = stack.Pop();

                    if (smallestNumber > number)
                    {
                        smallestNumber = number;
                    }
                }

                if (stack.Count == 0)
                {
                    Console.WriteLine(smallestNumber);
                    return;
                }
            }

            Console.WriteLine(0);
        }
    }
}
