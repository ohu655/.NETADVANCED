using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] filledBottles = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(filledBottles);
            int wastedWater = 0;
            int currentCup = 0;

            while (true)
            { 

                if (!cups.Any())
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    return;
                }
                else if (!bottles.Any())
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    return;
                }

                if (currentCup == 0)
                {
                    currentCup = cups.Peek();
                }
                
                int currentBottle = bottles.Peek();

                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                    cups.Dequeue();
                    bottles.Pop();
                    currentCup = 0;
                }
                else
                {
                    bottles.Pop();
                    currentCup -= currentBottle;
                }
            }
        }
    }
}
