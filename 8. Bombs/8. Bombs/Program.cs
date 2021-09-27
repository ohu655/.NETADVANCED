using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] bombs = new int[n, n];

            for (int row = 0; row < bombs.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < bombs.GetLength(1); col++)
                {
                    bombs[row, col] = input[col];
                }
            }
        
            string line = Console.ReadLine();
            string[] parts = line.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parts.Length; i++)
            {
                string[] elementParts = parts[i].Split(",");
                int bombRows = int.Parse(elementParts[0]);
                int bombCols = int.Parse(elementParts[1]);
                int bombPower = bombs[bombRows, bombCols];

                if (bombPower > 0)
                {

                    if (IsInside(bombs, bombRows - 1, bombCols - 1) && bombs[bombRows - 1, bombCols - 1] > 0)
                    {
                        bombs[bombRows - 1, bombCols - 1] -= bombs[bombRows, bombCols];
                    }

                    if (IsInside(bombs, bombRows - 1, bombCols) && bombs[bombRows - 1, bombCols] > 0)
                    {
                        bombs[bombRows - 1, bombCols] -= bombs[bombRows, bombCols];
                    }

                    if (IsInside(bombs, bombRows - 1, bombCols + 1) && bombs[bombRows - 1, bombCols + 1] > 0)
                    {
                        bombs[bombRows - 1, bombCols + 1] -= bombs[bombRows, bombCols];
                    }

                    if (IsInside(bombs, bombRows, bombCols - 1) && bombs[bombRows, bombCols - 1] > 0)
                    {
                        bombs[bombRows, bombCols - 1] -= bombs[bombRows, bombCols];
                    }

                    if (IsInside(bombs, bombRows, bombCols + 1) && bombs[bombRows, bombCols + 1] > 0)
                    {
                        bombs[bombRows, bombCols + 1] -= bombs[bombRows, bombCols];
                    }

                    if (IsInside(bombs, bombRows + 1, bombCols - 1) && bombs[bombRows + 1, bombCols - 1] > 0)
                    {
                        bombs[bombRows + 1, bombCols - 1] -= bombs[bombRows, bombCols];
                    }

                    if (IsInside(bombs, bombRows + 1, bombCols) && bombs[bombRows + 1, bombCols] > 0)
                    {
                        bombs[bombRows + 1, bombCols] -= bombs[bombRows, bombCols];
                    }

                    if (IsInside(bombs, bombRows + 1, bombCols + 1) && bombs[bombRows + 1, bombCols + 1] > 0)
                    {
                        bombs[bombRows + 1, bombCols + 1] -= bombs[bombRows, bombCols];
                    }

                    bombs[bombRows, bombCols] = 0;
                }
            }

            int sum = 0;
            int aliveCells = 0;

            for (int row = 0; row < bombs.GetLength(0); row++)
            {
                for (int col = 0; col < bombs.GetLength(1); col++)
                {
                    if (bombs[row,col] > 0)
                    {
                        sum += bombs[row, col];
                        aliveCells++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < bombs.GetLength(0); row++)
            {
                for (int col = 0; col < bombs.GetLength(1); col++)
                {
                    Console.Write($"{bombs[row, col]} ");
                }
                Console.WriteLine();
            }
        }


        private static bool IsInside(int[,] bombs, int row, int col)
        {
            return row >= 0 && row < bombs.GetLength(0) && col >= 0 && col < bombs.GetLength(1);
        }
    }
}
