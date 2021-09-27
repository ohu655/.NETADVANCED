using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
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
            char[,] game = new char[rows, cols];

            for (int row = 0; row < game.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < game.GetLength(1); col++)
                {
                    game[row, col] = input[col];
                }
            }

            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < game.GetLength(0); row++)
            {
                for (int col = 0; col < game.GetLength(1); col++)
                {
                    if (game[row, col] == 'P')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            string directions = Console.ReadLine();

            bool isDead = false;

            for (int i = 0; i < directions.Length; i++)
            {
                char command = directions[i];

                List<int[]> bunniesCordinates = BunniesCordinates(game);

                if (command == 'U')
                {
                    if (IsInside(game, startRow - 1, startCol))
                    {
                        if (game[startRow - 1, startCol] == 'B')
                        {
                            game[startRow, startCol] = '.';
                            BunnyExpand(game, bunniesCordinates, isDead);
                            Printed(game);
                            Console.WriteLine($"dead: {startRow - 1} {startCol}");
                            return;
                        }
                        else if (game[startRow - 1, startCol] == '.')
                        {
                            game[startRow, startCol] = '.';
                            startRow = startRow - 1;
                            BunnyExpand(game, bunniesCordinates, isDead);

                            if (isDead == true)
                            {
                                Printed(game);
                                Console.WriteLine($"dead: {startRow} {startCol}");
                                return;
                            }
                        }
                    }
                    else
                    {
                        game[startRow, startCol] = '.';
                        BunnyExpand(game, bunniesCordinates, isDead);
                        Printed(game);
                        Console.WriteLine($"won: {startRow} {startCol}");
                        return;
                    }
                }
                else if (command == 'D')
                {
                    if (IsInside(game, startRow + 1, startCol))
                    {
                        if (game[startRow + 1, startCol] == 'B')
                        {
                            game[startRow, startCol] = '.';
                            BunnyExpand(game, bunniesCordinates, isDead);
                            Printed(game);
                            Console.WriteLine($"dead: {startRow + 1} {startCol}");
                            return;
                        }
                        else if (game[startRow + 1, startCol] == '.')
                        {
                            game[startRow, startCol] = '.';
                            startRow = startRow + 1;
                            BunnyExpand(game, bunniesCordinates, isDead);

                            if (isDead == true)
                            {
                                Printed(game);
                                Console.WriteLine($"dead: {startRow} {startCol}");
                                return;
                            }
                        }
                    }
                    else
                    {
                        game[startRow, startCol] = '.';
                        BunnyExpand(game, bunniesCordinates, isDead);
                        Printed(game);
                        Console.WriteLine($"won: {startRow} {startCol}");
                        return;
                    }
                }
                else if (command == 'R')
                {
                    if (IsInside(game, startRow, startCol + 1))
                    {
                        if (game[startRow, startCol + 1] == 'B')
                        {
                            game[startRow, startCol] = '.';
                            BunnyExpand(game, bunniesCordinates, isDead);
                            Printed(game);
                            Console.WriteLine($"dead: {startRow} {startCol + 1}");
                            return;
                        }
                        else if (game[startRow, startCol + 1] == '.')
                        {
                            game[startRow, startCol] = '.';
                            startCol = startCol + 1;
                            BunnyExpand(game, bunniesCordinates, isDead);

                            if (isDead == true)
                            {
                                Printed(game);
                                Console.WriteLine($"dead: {startRow} {startCol}");
                                return;
                            }
                        }
                    }
                    else
                    {
                        game[startRow, startCol] = '.';
                        BunnyExpand(game, bunniesCordinates, isDead);
                        Printed(game);
                        Console.WriteLine($"won: {startRow} {startCol}");
                        return;
                    }
                }
                else if (command == 'L')
                {
                    if (IsInside(game, startRow, startCol - 1))
                    {
                        if (game[startRow, startCol - 1] == 'B')
                        {
                            game[startRow, startCol] = '.';
                            BunnyExpand(game, bunniesCordinates, isDead);
                            Printed(game);
                            Console.WriteLine($"dead: {startRow} {startCol - 1}");
                            return;
                        }
                        else if (game[startRow, startCol - 1] == '.')
                        {
                            game[startRow, startCol] = '.';
                            startCol = startCol - 1;
                            BunnyExpand(game, bunniesCordinates, isDead);

                            if (isDead == true)
                            {
                                Printed(game);
                                Console.WriteLine($"dead: {startRow} {startCol}");
                                return;
                            }
                        }
                    }
                    else
                    {
                        game[startRow, startCol] = '.';
                        BunnyExpand(game, bunniesCordinates, isDead);
                        Printed(game);
                        Console.WriteLine($"won: {startRow} {startCol}");
                        return;
                    }
                }
            }
        }

        private static List<int[]> BunniesCordinates(char[,] game)
        {
            List<int[]> bunniesCordinates = new List<int[]>();

            for (int row = 0; row < game.GetLength(0); row++)
            {
                for (int col = 0; col < game.GetLength(1); col++)
                {
                    if (game[row, col] == 'B')
                    {
                        bunniesCordinates.Add(new int[] { row, col });
                    }
                }
            }

            return bunniesCordinates;
        }

        private static void BunnyExpand(char[,] game, List<int[]> bunniesCordinates, bool isDead)
        {
            foreach (var item in bunniesCordinates)
            {
                int bunnyRow = item[0];
                int bunnyCol = item[1];

                if (IsInside(game, bunnyRow - 1, bunnyCol))
                {
                    if (game[bunnyRow - 1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }
                    game[bunnyRow - 1, bunnyCol] = 'B';
                }

                if (IsInside(game, bunnyRow + 1, bunnyCol))
                {
                    if (game[bunnyRow + 1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }
                    game[bunnyRow + 1, bunnyCol] = 'B';
                }

                if (IsInside(game, bunnyRow, bunnyCol - 1))
                {
                    if (game[bunnyRow, bunnyCol - 1] == 'P')
                    {
                        isDead = true;
                    }
                    game[bunnyRow, bunnyCol - 1] = 'B';
                }

                if (IsInside(game, bunnyRow, bunnyCol + 1))
                {
                    if (game[bunnyRow, bunnyCol + 1] == 'P')
                    {
                        isDead = true;
                    }
                    game[bunnyRow, bunnyCol + 1] = 'B';
                }
            }
        }

        private static void Printed(char[,] game)
        {
            for (int row = 0; row < game.GetLength(0); row++)
            {
                for (int col = 0; col < game.GetLength(1); col++)
                {
                    Console.Write(game[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(char[,] game, int row, int col)
        {
            return row >= 0 && row < game.GetLength(0) && col >= 0 && col < game.GetLength(1);
        }
    }
}
