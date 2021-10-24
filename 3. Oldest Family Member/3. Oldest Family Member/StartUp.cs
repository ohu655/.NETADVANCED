using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Console.Write($"{family.OldestMember().Name} ");
            Console.Write($"{family.OldestMember().Age}");
            
        }
    }
}
