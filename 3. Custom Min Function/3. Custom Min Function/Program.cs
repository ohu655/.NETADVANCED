using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> smallestNumber = input =>
            {
                int minValue = int.MaxValue;

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] < minValue)
                    {
                        minValue = input[i];
                    }
                }

                return minValue;
            };

            Console.WriteLine(smallestNumber(input));
        }
    }
}
