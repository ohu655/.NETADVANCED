using System;
using System.Collections.Generic;

namespace _4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 1);
                }
                else
                {
                    numbers[input] += 1;
                }
                
            }

            foreach (var kvp in numbers)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
