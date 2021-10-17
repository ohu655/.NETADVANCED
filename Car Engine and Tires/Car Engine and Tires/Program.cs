﻿using System;

namespace CarManufacturer
{

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
               new Tire(1, 2.5),
               new Tire(1, 2.1),
               new Tire(1, 2.5),
               new Tire(1, 2.5),
            };

            var engine = new Engine(560, 6300);

            var car = new Car("Lambo", "Urus", 2021, 250, 9, engine, tires);

            Console.WriteLine(car.Engine.CubicCapacity);
        }
    }
}
