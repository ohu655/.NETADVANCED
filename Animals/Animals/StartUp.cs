using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string type = Console.ReadLine();
                if (type == "Beast!")
                {
                    return;
                }

                string[] line = Console.ReadLine().Split();
                string name = line[0];
                int age = int.Parse(line[1]);
                string gender = line[2];

                if (age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                
                if (type == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine(type);
                    Console.WriteLine(cat.ToString());
                    Console.WriteLine(cat.ProduceSound());
                }
                else if (type == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(type);
                    Console.WriteLine(dog.ToString());
                    Console.WriteLine(dog.ProduceSound());
                }
                else if (type == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(type);
                    Console.WriteLine(frog.ToString());
                    Console.WriteLine(frog.ProduceSound());
                }
                else if (type == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    Console.WriteLine(type);
                    Console.WriteLine(tomcat.ToString());
                    Console.WriteLine(tomcat.ProduceSound());
                }
                else if (type == "Kitten ")
                {
                    Kitten kitten = new Kitten(name, age);
                    Console.WriteLine(type);
                    Console.WriteLine(kitten.ToString());
                    Console.WriteLine(kitten.ProduceSound());
                }
            }
        }
    }
}
