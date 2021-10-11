using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRange = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            List<int> sequence = new List<int>();

            for (int i = 1; i <= maxRange; i++)
            {
                sequence.Add(i);
            }

            Func<List<int>, List<int>> divisible = x =>
            {
                var result = new List<int>();
                bool isDivisible = true;

                foreach (var item in x)
                {
                    foreach (var element in numbers)
                    {
                        if (item % element == 0)
                        {
                            isDivisible = true;
                        }
                        else
                        {
                            isDivisible = false;
                            break;
                        }
                    }

                    if (isDivisible)
                    {
                        result.Add(item);
                    }
                }

                return result;
            };

            Console.WriteLine(string.Join(" ", divisible(sequence)));
        }
    }
}
