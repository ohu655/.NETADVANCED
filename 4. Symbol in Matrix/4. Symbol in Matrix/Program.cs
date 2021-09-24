using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] symbols = new char[n, n];

            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    symbols[row, col] = line[col];
                }
            }

            char wantedSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    if (symbols[row,col] == wantedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{wantedSymbol} does not occur in the matrix ");
        }
    }
}
