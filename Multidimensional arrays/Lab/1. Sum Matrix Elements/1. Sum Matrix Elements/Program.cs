using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];
            
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(", ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(parts[col]);
                }
            }

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
