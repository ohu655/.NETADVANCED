using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Box box = new Box();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                list.Add(input);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index1 = indexes[0];
            int index2 = indexes[1];

            box.Swap(list, index1, index2);

            foreach (var element in list)
            {
                Console.WriteLine($"System.Int32: {element}");
            }
        }
    }
}
