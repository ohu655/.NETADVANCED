using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Martin", 26);

            Console.WriteLine(person.Age);
        }
    }
}
