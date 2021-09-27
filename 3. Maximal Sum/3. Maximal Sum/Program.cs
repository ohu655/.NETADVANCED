using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = n[0];
            int cols = n[1];


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

            int sum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;


            for (int row = 0; row < numbers.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < numbers.GetLength(1) - 2; col++)
                {
                    int currentSum = numbers[row, col] + numbers[row, col + 1] + numbers[row, col + 2]
                        + numbers[row + 1, col] + numbers[row + 1, col + 1] + numbers[row + 1, col + 2]
                        + numbers[row + 2, col] + numbers[row + 2, col + 1] + numbers[row + 2, col + 2];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine(string.Join(" ", numbers[rowIndex, colIndex], numbers[rowIndex, colIndex + 1], numbers[rowIndex, colIndex + 2]));
            Console.WriteLine(string.Join(" ", numbers[rowIndex + 1, colIndex], numbers[rowIndex + 1, colIndex + 1], numbers[rowIndex + 1, colIndex + 2]));
            Console.WriteLine(string.Join(" ", numbers[rowIndex + 2, colIndex], numbers[rowIndex + 2, colIndex + 1], numbers[rowIndex + 2, colIndex + 2]));
            
        }
    }
}