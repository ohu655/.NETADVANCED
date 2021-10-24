using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person(25);

            Console.WriteLine(person.Name);
        }
    }
}
