using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = parts[0];
                int power = int.Parse(parts[1]);
                Engine engine = new Engine();
                engine.Model = model;
                engine.Power = power;

                if (parts.Length == 3)
                {
                    char stringFirstCharacter = parts[2].ToCharArray().ElementAt(0);

                    if (char.IsNumber(stringFirstCharacter))
                    {
                        int displacement = int.Parse(parts[2]);
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = parts[2];
                        engine.Efficiency = efficiency;
                    }
                }

                if (parts.Length == 4)
                {
                    int displacement = int.Parse(parts[2]);
                    string efficiency = parts[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                engines.Add(model, engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = parts[0];
                string engineModel = parts[1];

                Car car = new Car();
                car.Model = model;
                car.Engine = engines[engineModel];

                if (parts.Length == 3)
                {
                    char stringFirstCharacter = parts[2].ToCharArray().ElementAt(0);

                    if (char.IsNumber(stringFirstCharacter))
                    {
                        int weight = int.Parse(parts[2]);
                        car.Weight = weight;
                    }
                    else
                    {
                        string color = parts[2];
                        car.Color = color;
                    }                  
                }

                if (parts.Length == 4)
                {
                    int weight = int.Parse(parts[2]);
                    car.Weight = weight;
                    string color = parts[3];
                    car.Color = color;
                }

                cars.Add(model, car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key}:");
                Console.WriteLine($"  {car.Value.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Value.Engine.Power}");

                if (car.Value.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Value.Engine.Displacement}");
                }

                if (car.Value.Engine.Efficiency == null)
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: {car.Value.Engine.Efficiency}");
                }

                if (car.Value.Weight == 0)
                {
                    Console.WriteLine($"    Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"    Weight: {car.Value.Weight}");
                }

                if (car.Value.Color == null)
                {
                    Console.WriteLine($"    Color: n/a");
                }
                else
                {
                    Console.WriteLine($"    Color: {car.Value.Color}");
                }
            }
        }
    }
}
