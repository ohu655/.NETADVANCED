using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int numbersToEnque = numbers[0];
            int numbersToDeque = numbers[1];
            int numberToPeek = numbers[2];

            int[] numbersInQueue = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbersToEnque; i++)
            {
                int currentNumber = numbersInQueue[i];
                queue.Enqueue(currentNumber);
            }

            for (int i = 0; i < numbersToDeque; i++)
            {
                queue.Dequeue();
            }

            int smallestNumber = int.MaxValue;
            while (queue.Any())
            {
                if (queue.Peek() == numberToPeek)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    int number = queue.Dequeue();

                    if (smallestNumber > number)
                    {
                        smallestNumber = number;
                    }
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine(smallestNumber);
                    return;
                }
            }

            Console.WriteLine(0);
        }
    }
}
