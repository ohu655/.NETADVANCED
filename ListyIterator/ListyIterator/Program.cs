using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = null;

            while (true)
            {
                string[] line = Console.ReadLine().Split();

                if (line[0] == "END")
                {
                    break;
                }
                else if (line[0] == "Create")
                {
                    iterator = new ListyIterator<string>(line.Skip(1).ToArray());
                }
                else if (line[0] == "Move")
                {
                    Console.WriteLine(iterator.Move()); 
                }
                else if (line[0] == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext()); 
                }
                else if (line[0] == "Print")
                {
                    iterator.Print();
                }
                else if (line[0] == "PrintAll")
                {
                    iterator.PrintAll();
                }
            }
        }
    }
}
