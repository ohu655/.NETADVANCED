using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> sorted = parts.Where(x => char.IsUpper(x[0])).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
