using System;
using System.IO;

namespace _5._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileStream = new FileStream(@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\5. Slice a File\bigFile.txt", FileMode.OpenOrCreate);
            var data = new byte[fileStream.Length];

            var bytesPerFile = (int)Math.Ceiling(fileStream.Length / 4.0);

            for (int i = 0; i < 4; i++)
            {
                var buffer = new byte[bytesPerFile];
                fileStream.Read(buffer);

                using var writer = new FileStream($@"D:\Softuni C#\C# Advanced Projects\Streams Files and Directories\Lab\5. Slice a File\Part - {i}.txt", FileMode.OpenOrCreate);

                writer.Write(buffer);
            }
        }
    }
}
