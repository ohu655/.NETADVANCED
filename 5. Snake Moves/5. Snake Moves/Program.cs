using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] snake = new char[rows, cols];

            string input = Console.ReadLine();
            bool isLeftToRight = true;
            int counter = 0;

            for (int row = 0; row < snake.GetLength(0); row++)
            {
                if (isLeftToRight)
                {
                    for (int col = 0; col < snake.GetLength(1); col++)
                    {
                        snake[row, col] = input[counter++];

                        if (counter == input.Length)
                        {
                            counter = 0;
                        }

                        isLeftToRight = false;
                    }
                }
                else
                {
                    for (int col = snake.GetLength(1) -1; col >= 0; col--)
                    {
                        snake[row, col] = input[counter++];

                        if (counter == input.Length)
                        {
                            counter = 0;
                        }

                        isLeftToRight = true;
                    }
                }              
            }

            for (int row = 0; row < snake.GetLength(0); row++)
            {
                for (int col = 0; col < snake.GetLength(1); col++)
                {
                    Console.Write($"{snake[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
