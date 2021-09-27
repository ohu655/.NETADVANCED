using System;
using System.Linq;

namespace _2._2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] symbols = new char[rows, cols];

            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    symbols[row, col] = input[col];
                }
            }

            int counter = 0;


            for (int row = 0; row < symbols.GetLength(0) -1; row++)
            {
                for (int col = 0; col < symbols.GetLength(1) -1; col++)
                {
                    if (symbols[row, col] == symbols[row, col + 1])
                    {
                        if (symbols[row, col + 1] == symbols[row + 1, col])
                        {
                            if (symbols[row + 1, col] == symbols[row + 1, col + 1])
                            {
                                counter++;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
