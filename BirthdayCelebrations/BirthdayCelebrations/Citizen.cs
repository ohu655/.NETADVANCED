using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : Iidentifiable, IBuyer
    {

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string  Id { get; set; }

        public string BirthDate { get; set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 10;
        }

        public void GetBirthyear(string year)
        {
            string result = BirthDate.Substring(BirthDate.Length - year.Length);

            if (result == year)
            {
                Console.WriteLine(BirthDate);
            }
        }
    }
}
