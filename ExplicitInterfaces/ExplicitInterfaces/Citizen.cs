using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Country { get; set; }

        string IPerson.Name { get; set; }

        int IPerson.Age { get; set; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }

        string IPerson.GetName()
        {
            return Name;
        }
    }
}
