using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] diagonals = new int[n, n];

            for (int row = 0; row < diagonals.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < diagonals.GetLength(1); col++)
                {
                    diagonals[row, col] = input[col];
                }
            }

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int row = 0; row < diagonals.GetLength(0); row++)
            {
                firstDiagonalSum += diagonals[row, row];
            }

            for (int row = 0; row < diagonals.GetLength(0); row++)
            {
                secondDiagonalSum += diagonals[row, (diagonals.GetLength(0) -1) - row];              
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
