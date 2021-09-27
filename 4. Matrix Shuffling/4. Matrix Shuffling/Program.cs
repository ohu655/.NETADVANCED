using System;
using System.Linq;

namespace _4._Matrix_Shuffling
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = parts[col];
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "swap")
                {
                    if (parts.Length == 5)
                    {
                        int row1 = int.Parse(parts[1]);
                        int col1 = int.Parse(parts[2]);
                        int row2 = int.Parse(parts[3]);
                        int col2 = int.Parse(parts[4]);

                        if (row1 >= matrix.GetLength(0) || row1 < 0 ||
                    col1 >= matrix.GetLength(1) || col1 < 0 ||
                    row2 >= matrix.GetLength(0) || row2 < 0 ||
                    col2 >= matrix.GetLength(1) || col2 < 0)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }
                        else
                        {
                            string currentElement = matrix[row1, col1];
                            matrix[row1, col1] = matrix[row2, col2];
                            matrix[row2, col2] = currentElement;


                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write($"{matrix[i, j]} ");
                                }

                                Console.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
                else if (command == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }
    }
}
