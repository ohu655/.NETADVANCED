using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> add = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += 1;
                }
                return numbers;
            };
            Func<int[], int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }
                return numbers;
            };
            Func<int[], int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }
                return numbers;
            };

            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    add(input);
                }
                else if (command == "subtract")
                {
                    subtract(input);
                }
                else if (command == "multiply")
                {
                    multiply(input);
                }
                else if (command == "print")
                {
                    print(input);
                }
            }
        }
    }
}
