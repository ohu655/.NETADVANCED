using System;
using System.Collections.Generic;

namespace _6._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> plates = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split(", ");
                string command = parts[0];
                string plate = parts[1];

                if (command == "IN")
                {
                    plates.Add(plate);
                }
                else if (command == "OUT")
                {
                    plates.Remove(plate);
                }
            }

            if (plates.Count > 0)
            {
                foreach (var car in plates)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
