using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> clients = new Queue<int>(orders);

            Console.WriteLine(clients.Max());

            while (clients.Any())
            {
                if (quantityFood >= clients.Peek())
                {
                    int soldFood = clients.Dequeue();

                    quantityFood -= soldFood;
             
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", clients)}");
                    return;
                }
            }

            Console.WriteLine($"Orders complete");

        }
    }
}
