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
            using var sw = new StreamWriter(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\3. Word Count\output.txt");
            using var srWords = new StreamReader(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\3. Word Count\words.txt");
            using var srInput = new StreamReader(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\3. Word Count\input.txt");

            var keywords = new HashSet<string>();

            while (!srWords.EndOfStream)
            {
                string words = srWords.ReadLine().ToLower();

                string[] parts = words.Split();

                for (int i = 0; i < parts.Length; i++)
                {
                    keywords.Add(parts[i]);
                }
            }

            var output = new Dictionary<string, int>();

            while (!srInput.EndOfStream)
            {
                string row = srInput.ReadLine().ToLower();

                foreach (var item in keywords)
                {
                    if (row.Contains(item))
                    {
                        if (!output.ContainsKey(item))
                        {
                            output.Add(item, 1);
                        }
                        else
                        {
                            output[item] += 1;
                        }
                    }
                }
            }

            foreach (var kvp in output.OrderByDescending(n=> n.Value))
            {
                sw.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
