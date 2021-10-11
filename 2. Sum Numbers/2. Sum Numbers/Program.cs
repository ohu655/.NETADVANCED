using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());
        }
    }
}
