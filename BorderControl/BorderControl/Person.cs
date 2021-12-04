using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Person : IPerson
    {
        public Person(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }

        public string Id { get; set; }

        public void IsFake(string digits)
        {
            string lastDigits = Id.Substring(Id.Length - digits.Length);

            if (lastDigits == digits)
            {
                Console.WriteLine(Id);
            }
        }
    }
}
