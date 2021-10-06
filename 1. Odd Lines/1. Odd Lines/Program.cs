using System;
using System.IO;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\1. Odd Lines\input.txt");

            using StreamWriter sw = new StreamWriter(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\1. Odd Lines\output.txt");

            int count = 0;

            while (!sr.EndOfStream)
            {
                string currentRow = sr.ReadLine();
                
                if (count % 2 == 1)
                {
                    sw.WriteLine(currentRow);
                }

                count++;
            }
        }
    }
}
