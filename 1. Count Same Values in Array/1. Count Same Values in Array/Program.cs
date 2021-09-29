using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!count.ContainsKey(input[i]))
                {
                    count.Add(input[i], 1);
                }
                else
                {
                    count[input[i]] += 1;
                }
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }

        }
    }
}
