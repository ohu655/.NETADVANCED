using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isLargerOrEqual = (name, asciiSum) => name.Sum(x => x) >= asciiSum;

            Func<List<string>, int, Func<string, int, bool>, string> desiredName = (names, number, func) =>
            names.FirstOrDefault(x => func(x, number));

            string name = desiredName(names, n, isLargerOrEqual);

            Console.WriteLine(name);
        }
    }
}
