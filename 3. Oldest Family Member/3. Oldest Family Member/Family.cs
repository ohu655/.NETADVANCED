using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }

        public List<Person> Persons { get; set; }

        public void AddMember(Person person)
        {
            Persons.Add(person);
        }

        public Person OldestMember()
        {
            Person oldestPerson = Persons.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestPerson;
        }
    }
}
