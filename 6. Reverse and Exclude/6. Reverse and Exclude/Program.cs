using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divisibleNumber = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> divisible = x =>
            {
                var result = new List<int>();

                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i] % divisibleNumber != 0)
                    {
                        result.Add(x[i]);
                    }
                }

                return result;
            };

            var result = divisible(input);
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
