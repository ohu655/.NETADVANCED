using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            Queue<string> cars = new Queue<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                else if (line == "green")
                {
                    if (cars.Count > n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            string passedCar = cars.Dequeue();
                            Console.WriteLine($"{passedCar} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        while (cars.Count != 0)
                        {
                            string passedCar = cars.Dequeue();
                            Console.WriteLine($"{passedCar} passed!");
                            counter++;
                        }
                    }
                   
                }
                else
                {
                    cars.Enqueue(line);
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
