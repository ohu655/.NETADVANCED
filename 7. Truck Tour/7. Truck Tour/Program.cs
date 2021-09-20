using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> petrolStations = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int petrol = input[0];
                int distance = input[1];

                petrolStations.Enqueue(input);

            }

            int counter = 0;
            

            while (true)
            {
                int tankCapacity = 0;

                foreach (var element in petrolStations)
                {
                    int currentPetrol = element[0];
                    int currentDistance = element[1];

                    tankCapacity += currentPetrol;
                    tankCapacity -= currentDistance;

                    if (tankCapacity < 0)
                    {
                        int[] elementToRemove = petrolStations.Dequeue();
                        petrolStations.Enqueue(elementToRemove);
                        counter++;
                        break;
                    }
                }

                if (tankCapacity >= 0)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
