using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"words.txt");

            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < lines.Length; i++)
            {
                words.Add(lines[i], 0);
            }

            string[] textLines = File.ReadAllLines(@"text.txt");

            foreach (var line in textLines)
            {
                foreach (var word in words)
                {
                    if (line.Contains(word.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        words[word.Key]++;
                    }
                }
               
            }

            foreach (var item in words)
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";
                File.AppendAllText(@"actualResult.txt", result);
            }

            foreach (var item in words.OrderByDescending(n => n.Value))
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";
                File.AppendAllText(@"expectedResult.txt", result);
            }
        }
    }
}

