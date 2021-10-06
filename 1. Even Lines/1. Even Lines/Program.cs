using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            using var writer = new StreamWriter(@".\output.txt");

            char[] symbols = { '-', ',', '.', '!', '?' }; 

            int count = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (count % 2 == 0)
                {
                    foreach (var symbol in symbols)
                    {
                        line = line.Replace(symbol, '@');
                    }

                    writer.WriteLine(string.Join(" ", line.Split().Reverse()));
                }

                count++;
            }
        }
    }
}
