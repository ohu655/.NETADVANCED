using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] numbers = new int[rows, cols];

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = input[col];
                }
            }


            for (int col = 0; col < numbers.GetLength(1); col++)
            {
                int sumCols = 0;
                for (int row = 0; row < numbers.GetLength(0); row++)
                {
                    sumCols += numbers[row, col];
                   
                }

                Console.WriteLine(sumCols);
                
            }
        }
    }
}
