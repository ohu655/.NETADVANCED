using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valueOfClothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> boxOfClothes = new Stack<int>(valueOfClothes);

            int boxesCounter = 1;
            int sum = 0;

            for (int i = valueOfClothes.Length - 1; i >= 0; i--)
            {
                sum += valueOfClothes[i];

                if (sum <= capacityOfRack)
                {
                    if (boxOfClothes.Any())
                    {
                        int removedCloth = boxOfClothes.Pop();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                    boxesCounter++;
                    sum = 0;
                }
            }     
            Console.WriteLine(boxesCounter);
        }
    }
}
