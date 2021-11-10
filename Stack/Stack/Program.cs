using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                string[] line = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];

                if (command == "END")
                {
                    break;
                }
                else if (command == "Push")
                {
                    stack.Push(line.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("No elements");
                    }
                    
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
