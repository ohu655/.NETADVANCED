using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string model = parts[0];
                double fuelAmount = double.Parse(parts[1]);
                double fuelComsumption = double.Parse(parts[2]);

                Car car = new Car(model, fuelAmount, fuelComsumption);
                cars.Add(car);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();
                string model = parts[1];
                double amountOfKm = double.Parse(parts[2]);

                Car carForDriving = cars.Where(x => x.Model == model).ToList().First();

                carForDriving.Drive(amountOfKm);
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
