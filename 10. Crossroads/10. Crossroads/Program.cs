using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int counter = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
                else if (line == "green")
                {
                    
                    int greenWindow = greenDuration;

                    while (greenWindow > 0 && cars.Count > 0)
                    {
                        string currentCar = cars.Peek();

                        if (greenWindow >= currentCar.Length)
                        {
                            cars.Dequeue();
                            greenWindow -= currentCar.Length;
                            counter++;
                        }
                        else if (greenWindow < currentCar.Length)
                        {
                            if (greenWindow + freeWindow >= currentCar.Length)
                            {
                                cars.Dequeue();
                                greenWindow = 0;
                                counter++;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {currentCar.Substring((greenWindow + freeWindow), 1)}.");
                                return;
                            }
                        }
                    }          
                }
                else
                {
                    cars.Enqueue(line);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");

        }
    }
}
