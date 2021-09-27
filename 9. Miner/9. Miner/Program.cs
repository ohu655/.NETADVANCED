using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] miner = new char[n, n];

            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int row = 0; row < miner.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < miner.GetLength(1); col++)
                {
                    miner[row, col] = input[col];
                }
            }

            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < miner.GetLength(0); row++)
            {
                for (int col = 0; col < miner.GetLength(1); col++)
                {
                    if (miner[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            int allCoals = SumOfCoals(miner);
            int collectedCoals = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                string command = directions[i];

                if (command == "up")
                {
                    if (IsInside(miner, startRow - 1, startCol))
                    {
                        if (miner[startRow - 1, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow - 1}, {startCol})");
                            return;
                        }
                        else if (miner[startRow - 1, startCol] == 'c')
                        {
                            collectedCoals++;

                            if (collectedCoals == allCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow - 1}, {startCol})");
                                return;
                            }
                            else
                            {
                                miner[startRow - 1, startCol] = '*';
                                startRow = startRow - 1;
                            }   
                        }
                        else
                        {
                            startRow = startRow - 1;
                        }                       
                    }
                }
                else if (command == "down")
                {
                    if (IsInside(miner, startRow + 1, startCol))
                    {
                        if (miner[startRow + 1, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow + 1}, {startCol})");
                            return;
                        }
                        else if (miner[startRow + 1, startCol] == 'c')
                        {
                            collectedCoals++;

                            if (collectedCoals == allCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow + 1}, {startCol})");
                                return;
                            }
                            else
                            {
                                miner[startRow + 1, startCol] = '*';
                                startRow = startRow + 1;
                            }
                        }
                        else
                        {
                            startRow = startRow + 1;
                        }
                    }
                }
                else if (command == "right")
                {
                    if (IsInside(miner, startRow, startCol + 1))
                    {
                        if (miner[startRow, startCol + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol + 1})");
                            return;
                        }
                        else if (miner[startRow, startCol + 1] == 'c')
                        {
                            collectedCoals++;

                            if (collectedCoals == allCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow}, {startCol + 1})");
                                return;
                            }
                            else
                            {
                                miner[startRow, startCol + 1] = '*';
                                startCol = startCol + 1;
                            }
                        }
                        else
                        {
                            startCol = startCol + 1;
                        }
                    }
                }
                else if (command == "left")
                {
                    if (IsInside(miner, startRow, startCol - 1))
                    {
                        if (miner[startRow, startCol - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol - 1})");
                            return;
                        }
                        else if (miner[startRow, startCol - 1] == 'c')
                        {
                            collectedCoals++;

                            if (collectedCoals == allCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow}, {startCol - 1})");
                                return;
                            }
                            else
                            {
                                miner[startRow, startCol - 1] = '*';
                                startCol = startCol - 1;
                            }
                        }
                        else
                        {
                            startCol = startCol - 1;
                        }
                    }
                }
            }

            Console.WriteLine($"{allCoals - collectedCoals} coals left. ({startRow}, {startCol})");
        }

        private static int SumOfCoals(char[,] miner)
        {
            int sum = 0;

            for (int row = 0; row < miner.GetLength(0); row++)
            {
                for (int col = 0; col < miner.GetLength(1); col++)
                {
                    if (miner[row, col] == 'c')
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        private static bool IsInside(char[,] miner, int row, int col)
        {
            return row >= 0 && row < miner.GetLength(0) && col >= 0 && col < miner.GetLength(1);
        }
    }
}
