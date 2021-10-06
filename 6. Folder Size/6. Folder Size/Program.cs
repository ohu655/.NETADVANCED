using System;
using System.IO;

namespace _6._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\Resources\06. Folder Size\TestFolder";

            string[] directory = Directory.GetFiles(path);
            long totalLenght = 0;

            foreach (var item in directory)
            {
                totalLenght += new FileInfo(item).Length;
            }

            Console.WriteLine(totalLenght / 1048576.0);
        }
    }
}
