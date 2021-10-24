using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();


            for (int i = 0; i < n; i++)
            {
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string[] parts = Console.ReadLine().Split();
                string model = parts[0];
                int engineSpeed = int.Parse(parts[1]);
                int enginePower = int.Parse(parts[2]);
                int cargoWeight = int.Parse(parts[3]);
                string cargoType = parts[4];
                List<Tire> tires = new List<Tire>();

                for (int j = 5; j <= 12; j += 2)
                {
                    double pressure = double.Parse(parts[j]);
                    int age = int.Parse(parts[j + 1]);
                    Tire tire = new Tire(age, pressure);
                    tires.Add(tire);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Car car = new Car(model, engine, cargo,tires);
                cars.Add(car);
            }

            string typeOfCargo = Console.ReadLine();

            if (typeOfCargo == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "fragile"))
                {
                    foreach (var tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }                       
                    }
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "flammable"))
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }                   
                }
            }
        }
    }
}
