using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string pizzaName = pizzaInfo[1];

                string[] doughInfo = Console.ReadLine().Split();
                string flour = doughInfo[1];
                string bakingTechnique = doughInfo[2];
                int grams = int.Parse(doughInfo[3]);

                Dough dough = new Dough(flour, bakingTechnique, grams);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }

                    string[] parts = line.Split();

                    string toppingName = parts[1];
                    int toppingGrams = int.Parse(parts[2]);
                    Topping topping = new Topping(toppingName, toppingGrams);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.ToString()}");
            }
             catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
