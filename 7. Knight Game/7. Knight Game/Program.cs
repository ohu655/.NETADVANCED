using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = line[col];
                }
            }

            int removedKnights = 0;
            while (true)
            {
                int maxAtacks = 0;
                int rowPosition = 0;
                int colPosition = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentAtack = 0;
                        if (board[row, col] != 'K')
                        {
                            continue;
                        }

                        if (IsInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currentAtack++;
                        }

                        if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currentAtack++;
                        }

                        if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currentAtack++;
                        }

                        if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currentAtack++;
                        }

                        if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currentAtack++;
                        }

                        if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currentAtack++;
                        }

                        if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currentAtack++;
                        }

                        if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currentAtack++;
                        }

                        if (currentAtack > maxAtacks)
                        {
                            maxAtacks = currentAtack;
                            rowPosition = row;
                            colPosition = col;
                        }
                    }
                }

                if (maxAtacks == 0)
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
                else
                {
                    board[rowPosition, colPosition] = '0';
                    removedKnights++;
                }
            }
        }

        private static bool IsInside(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }
    }
}
