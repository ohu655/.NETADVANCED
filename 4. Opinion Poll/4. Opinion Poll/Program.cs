using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);

                Person person = new Person(name, age);
                persons.Add(person);
            }

            foreach (var person in persons.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.Write($"{person.Name} - ");
                Console.Write($"{person.Age}");

                Console.WriteLine();
            }
        }
    }
}
