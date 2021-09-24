using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] numbers = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                numbers[row] = new int[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    numbers[row][col] = input[col];
                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (row >= numbers.Length || row < 0 || col >= numbers[row].Length || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command == "Add")
                {

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        for (int j = 0; j < numbers[i].Length; j++)
                        {
                            if (i == row && j == col)
                            {
                                numbers[i][j] += value;
                            }
                        }
                    }
                }
                else if (command == "Subtract")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        for (int j = 0; j < numbers[i].Length; j++)
                        {
                            if (i == row && j == col)
                            {
                                numbers[i][j] -= value;
                            }
                        }
                    }
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

