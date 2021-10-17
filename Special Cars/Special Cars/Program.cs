using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "No more tires")
                {
                    break;
                }

                string[] parts = line.Split();

                Tire[] tire = new Tire[]
                {
                    new Tire(int.Parse(parts[0]), double.Parse(parts[1])),
                    new Tire(int.Parse(parts[2]), double.Parse(parts[3])),
                    new Tire(int.Parse(parts[4]), double.Parse(parts[5])),
                    new Tire(int.Parse(parts[6]), double.Parse(parts[7])),
                };

                tires.Add(tire);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Engines done")
                {
                    break;
                }

                string[] parts = line.Split();
                int horsePower = int.Parse(parts[0]);
                double cubic = double.Parse(parts[1]);

                Engine engine = new Engine(horsePower, cubic);

                engines.Add(engine);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Show special")
                {
                    break;
                    
                }

                string[] parts = line.Split();
                string make = parts[0];
                string model = parts[1];
                int year = int.Parse(parts[2]);
                int fuelQuantity = int.Parse(parts[3]);
                int fuelConsumption = int.Parse(parts[4]);
                int engineIndex = int.Parse(parts[5]);
                int tiresIndex = int.Parse(parts[6]);

                Car car = new Car
                    (make, model, year, fuelQuantity, 
                    fuelConsumption, engines.ElementAt(engineIndex), tires.ElementAt(tiresIndex));

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 &&
                    car.TirePressure() > 9 && car.TirePressure() < 10)
                {
                    car.FuelQuantity = car.Drive20Kilometers(car.FuelQuantity, car.FuelConsumption);

                    Console.WriteLine($"Make: {car.Make}");

                    Console.WriteLine($"Model: {car.Model}");

                    Console.WriteLine($"Year: {car.Year}");

                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");

                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
            
        }
    }
}
