using System;
using System.Collections.Generic;
using System.Text;

namespace _6.SpeedRacing
{
    public class Car
    {

        public Car(string model, double fuelAmount, double fuelComsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelComsumptionPerKilometer = fuelComsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelComsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            double comsumedFuel = amountOfKm * FuelComsumptionPerKilometer;

            if (comsumedFuel <= FuelAmount)
            {
                FuelAmount -= comsumedFuel;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
