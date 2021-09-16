using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split().
                Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                stack.Push(number);
            }

            while (true)
            {
                string line = Console.ReadLine().ToLower();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "add")
                {
                    int firstNumber = int.Parse(parts[1]);
                    int secondNumber = int.Parse(parts[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (command == "remove")
                {
                    int numbersToRemove = int.Parse(parts[1]);

                    if (stack.Count >= numbersToRemove)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            int sum = 0;

            while (stack.Count != 0)
            {
                int element = stack.Peek();
                sum += element;
                stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
