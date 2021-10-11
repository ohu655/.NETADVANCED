using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Filter_by_Age
{
    class Person
    {
        public string Name;

        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                int age = int.Parse(parts[1]);

                Person person = new Person();
                person.Name = name;
                person.Age = age;

                people.Add(person);

            }

            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = p => true;

            if (condition == "older")
            {
                filter = p => p.Age >= ageCondition; 
            }
            else if (condition == "younger")
            {
                filter = p => p.Age < ageCondition;
            }

            var filteredPeople = people.Where(filter);

            Func<Person, string> printCondition = p => p.Name + " - " + p.Age;
            if (format == "name age")
            {
                printCondition = p => p.Name + " - " + p.Age;
            }
            else if (format == "age")
            {
                printCondition = p => p.Age.ToString();
            }
            else if (format == "name")
            {
                printCondition = p => p.Name;
            }

            var result = filteredPeople.Select(printCondition);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
