using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;

            set
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }

                fuelQuantity = value;
            }
        }

        public virtual double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public bool IsEmpty { get; set; }

        public virtual string Drive(double distance)
        {
            double fuelNeeded = distance * FuelConsumption;

            if (fuelNeeded >= FuelQuantity)
            {
                return $"{GetType().Name} needs refueling";
            }

            FuelQuantity -= fuelNeeded;

            return $"{GetType().Name} travelled {distance} km";
        }


        public virtual void Refuel(double litters)
        {
            if (litters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + litters > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {litters} fuel in the tank");
            }

            FuelQuantity += litters;
        }
    }
}
