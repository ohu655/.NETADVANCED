using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sr = new StreamReader(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\2. Line Numbers\input.txt");

            using var sw = new StreamWriter(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\2. Line Numbers\output.txt");

            int count = 1;

            while (!sr.EndOfStream)
            {
                string currentRow = sr.ReadLine();

                sw.WriteLine($"{count}. {currentRow}");

                count++;
            }
        }
    }
}
