using System;
using System.IO;

namespace BoxOfT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            box.Add(1);
            box.Add(5);
            box.Add(3);
            Console.WriteLine(box.Remove());

        }
    }
}
