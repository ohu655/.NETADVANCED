﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PrinEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbersInQueue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    numbersInQueue.Enqueue(currentNumber);
                }
            }

            while (numbersInQueue.Count != 0)
            {
                if (numbersInQueue.Count == 1)
                {
                    Console.Write(numbersInQueue.Dequeue()); 
                }
                else
                {
                    Console.Write($"{numbersInQueue.Dequeue()}, ");
                }
            }
        }
    }
}
