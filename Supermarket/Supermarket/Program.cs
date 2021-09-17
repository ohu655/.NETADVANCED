using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }
                else if (line == "Paid")
                {
                    while (clients.Count != 0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
                else
                {
                    clients.Enqueue(line);
                }
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
