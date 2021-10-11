using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> result = new List<int>();

            for (int i = input[0]; i <= input[1]; i++)
            {
                result.Add(i);
            }

            Predicate<int> isEven = x => x % 2 == 0;

            foreach (var item in result)
            {
                if (command == "odd")
                {
                    if (!isEven(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
                else
                {
                    if(isEven(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}
