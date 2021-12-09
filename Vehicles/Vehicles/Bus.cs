using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => this.IsEmpty ? base.FuelConsumption : base.FuelConsumption + 1.4;

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
