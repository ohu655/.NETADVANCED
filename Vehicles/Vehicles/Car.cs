using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + 0.9;

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }

        public override void Refuel(double litters)
        {
            base.Refuel(litters);
        }
    }
}
