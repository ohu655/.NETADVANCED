using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            List<double> withVAT = input.Select(x => x * 1.2).ToList();

            foreach (var item in withVAT)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
