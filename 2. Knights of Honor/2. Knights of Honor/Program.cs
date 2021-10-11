using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Action<List<string>> print = x => x.ForEach(x => Console.WriteLine($"Sir {x}"));

            print(input);
        }
    }
}
