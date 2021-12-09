using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Foods;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();
            

            while (input != "End")
            {
                string[] animalInfo = input.Split();
                string[] foodInfo = Console.ReadLine().Split();

                string type = animalInfo[0];

                try
                {
                    Animal animal = null;

                    if (type == "Cat")
                    {

                        string name = animalInfo[1];
                        double weight = double.Parse(animalInfo[2]);
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        animal = new Cat(name, weight, livingRegion, breed);

                    }
                    else if (type == "Tiger")
                    {
                        string name = animalInfo[1];
                        double weight = double.Parse(animalInfo[2]);
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                    else if (type == "Owl")
                    {
                        string name = animalInfo[1];
                        double weight = double.Parse(animalInfo[2]);
                        double wingSize = double.Parse(animalInfo[3]);

                        animal = new Owl(name, weight, wingSize);
                    }
                    else if (type == "Hen")
                    {
                        string name = animalInfo[1];
                        double weight = double.Parse(animalInfo[2]);
                        double wingSize = double.Parse(animalInfo[3]);

                        animal = new Hen(name, weight, wingSize);
                    }
                    else if (type == "Dog")
                    {
                        string name = animalInfo[1];
                        double weight = double.Parse(animalInfo[2]);
                        string livingRegion = animalInfo[3];

                        animal = new Dog(name, weight, livingRegion);
                    }
                    else if (type == "Mouse")
                    {
                        string name = animalInfo[1];
                        double weight = double.Parse(animalInfo[2]);
                        string livingRegion = animalInfo[3];

                        animal = new Mouse(name, weight, livingRegion);
                    }

                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);

                    string foodName = foodInfo[0];
                    int quantity = int.Parse(foodInfo[1]);

                    Food food = null;

                    if (foodName == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                    }
                    else if (foodName == "Fruit")
                    {
                        food = new Fruit(quantity);
                    }
                    else if (foodName == "Meat")
                    {
                        food = new Meat(quantity);
                    }
                    else if (foodName == "Seeds")
                    {
                        food = new Seeds(quantity);
                    }

                    animal.Feed(food);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
