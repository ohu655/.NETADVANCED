using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int maxElement = int.MinValue;
            int minElement = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "1")
                {
                    int numberToPush = int.Parse(parts[1]);

                    stack.Push(numberToPush);

                    if (minElement > stack.Peek())
                    {
                        minElement = stack.Peek();
                    }

                    if (maxElement < stack.Peek())
                    {
                        maxElement = stack.Peek();
                    }
                }
                else if (command == "2")
                {
                    if (stack.Any())
                    {
                        int elementToRemove = stack.Pop();

                        if (minElement == elementToRemove)
                        {
                            minElement = int.MaxValue;
                        }

                        if (maxElement == elementToRemove)
                        {
                            maxElement = int.MinValue;
                        }
                    }         
                }
                else if (command == "3")
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(maxElement);
                    }
                    
                }
                else if (command == "4")
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(minElement);
                    }
                    
                }
            }

            Console.WriteLine($"{string.Join(", ", stack)}");
        }
    }
}
