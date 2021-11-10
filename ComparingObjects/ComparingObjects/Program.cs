using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string[] line = Console.ReadLine().Split();

                if (line[0] == "END")
                {
                    break;
                }

                Person person = new Person(line[0], int.Parse(line[1]), line[2]);
                persons.Add(person);
            }

            int number = int.Parse(Console.ReadLine()) - 1;
            int numberOfMatches = 0;
            int notEqual = 0;

            foreach (Person person in persons)
            {
                if (persons[number].CompareTo(person) == 0)
                {
                    numberOfMatches++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (numberOfMatches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numberOfMatches} {notEqual} {persons.Count}");
            }
            
        }
    }
}
