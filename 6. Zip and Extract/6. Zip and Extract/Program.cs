using System;
using System.IO;
using System.IO.Compression;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@".", @"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Exercise\6. Zip and Extract\6. Zip and Extract\result.zip");
        }
    }
}
