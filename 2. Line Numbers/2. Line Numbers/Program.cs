using System;
using System.IO;
using System.Linq;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"text.txt");
            string path = @".\otput.txt";

            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Count(symbol => char.IsLetter(symbol));
                int punctoationCount = lines[i].Count(symbol => char.IsPunctuation(symbol));
                lines[i] = $"Line {i+1}:{lines[i]}({letterCount})({punctoationCount})";
            }

            File.WriteAllLines(path, lines);
        }
    }
}
