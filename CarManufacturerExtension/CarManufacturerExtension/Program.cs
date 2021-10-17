using System;

namespace CarManufacturer
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 1;
            car.Drive(100);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
