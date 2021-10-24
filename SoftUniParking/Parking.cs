using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            Capacity = capacity;
            Cars = new Dictionary<string, Car>();
        }

        public int Count => Cars.Count;

        public Dictionary<string, Car> Cars { get; set; }

        public int Capacity { get; set; }

        public string AddCar(Car car)
        {
            if (Cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (Cars.Count >= Capacity)
            {
                return "Parking is full!";
            }

            Cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";


        }

        public string RemoveCar(string registrationNumber)
        {
            if (!Cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        => Cars.FirstOrDefault(x => x.Key == registrationNumber).Value;

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var reg in registrationNumbers)
            {
                Cars.Remove(reg);
            }
        }
    }
}
