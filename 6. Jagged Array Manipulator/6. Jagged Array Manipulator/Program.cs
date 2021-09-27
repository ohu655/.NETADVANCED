using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] numbers = new double[n][];

            for (int i = 0; i < n; i++)
            {
                double[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                numbers[i] = new double[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    numbers[i][j] = input[j];
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i].Length == numbers[i + 1].Length)
                {

                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        numbers[i][j] *= 2;
                        numbers[i + 1][j] *= 2;
                    }
                }
                else
                {
                    if (numbers[i].Length > numbers[i + 1].Length)
                    {
                        for (int j = 0; j < numbers[i].Length; j++)
                        {
                            numbers[i][j] /= 2;

                            if (j >= numbers[i + 1].Length)
                            {
                                continue;
                            }
                            else
                            {
                                numbers[i + 1][j] /= 2;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < numbers[i + 1].Length; j++)
                        {
                            numbers[i + 1][j] /= 2;

                            if (j >= numbers[i].Length)
                            {
                                continue;
                            }
                            else
                            {
                                numbers[i][j] /= 2;
                            }
                        }

                    }
                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    Printed(numbers, n);
                    return;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Add")
                {
                    int row = int.Parse(parts[1]);
                    int col = int.Parse(parts[2]);
                    double value = double.Parse(parts[3]);

                    if (IsValid(row, col, numbers))
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
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(parts[1]);
                    int col = int.Parse(parts[2]);
                    double value = double.Parse(parts[3]);

                    if (IsValid(row, col, numbers))
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
                    else
                    {
                        continue;
                    }
                }
            }          
        }

        private static bool IsValid(int row, int col, double[][] numbers)
        {
            if (row >= numbers.Length || row < 0 || col >= numbers[row].Length || col < 0)
            {
                return false;
            }

            return true;
        }

        private static void Printed(double[][] numbers, int n)
        {
            for (int i = 0; i < n; i++)
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
