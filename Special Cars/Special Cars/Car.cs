using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double consumption = distance * FuelConsumption;

            if (FuelQuantity - consumption > 0)
            {
                FuelQuantity -= consumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            string result = $"Make: {this.Make}\nModel: {this.Model}" +
                $"\nYear: {this.Year}\nHorsePpowers: {this.Engine.HorsePower}\nFuelQuantity: {this.FuelQuantity}";

            return result;
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public double TirePressure()
        {
            double sum = 0;

            for (int i = 0; i < Tires.Length; i++)
            {
                sum += Tires[i].Pressure;
            }

            return sum;
        }

        public double Drive20Kilometers(double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= (fuelConsumption / 100) * 20;

            return fuelQuantity;
        }

    }
}
