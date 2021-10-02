using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int m = input[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            var final = firstSet.Intersect(secondSet);

            foreach (var item in final)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
