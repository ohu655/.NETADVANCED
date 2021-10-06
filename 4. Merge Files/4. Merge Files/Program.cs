using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _4._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sr1 = new StreamReader(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\4. Merge Files\input1.txt");
            using var sr2 = new StreamReader(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\4. Merge Files\input2.txt");
            using var sw = new StreamWriter(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\4. Merge Files\output.txt");

            var output = new Queue<string>();

            while (!sr2.EndOfStream)
             {
                output.Enqueue(sr1.ReadLine());
                output.Enqueue(sr2.ReadLine());
            }

            for (int i = 0; i < output.Count; i++)
            {
                sw.WriteLine(output.Dequeue());
                i--;
            }
        }
    }
}
