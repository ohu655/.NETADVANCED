using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] numbers = new long[n][];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = new long[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                numbers[i][0] = 1;
                numbers[i][numbers[i].Length - 1] = 1;

                for (int j = 1; j < numbers[i].Length - 1; j++)
                {
                    numbers[i][j] = numbers[i - 1][j - 1] + numbers[i - 1][j];
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
