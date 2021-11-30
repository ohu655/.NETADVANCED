using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, Person> persons = new Dictionary<string, Person>();
                Dictionary<string, Product> products = new Dictionary<string, Product>();

                string[] personInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                string[] productInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (var people in personInput)
                {
                    string[] values = people.Split("=");
                    string name = values[0];
                    decimal money = decimal.Parse(values[1]);

                    Person person = new Person(name, money);
                    persons.Add(name, person);
                }

                foreach (var prod in productInput)
                {
                    string[] values = prod.Split("=");
                    string name = values[0];
                    decimal cost = decimal.Parse(values[1]);

                    Product product = new Product(name, cost);
                    products.Add(name, product);
                }

                while (true)
                {
                    string line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }

                    string[] parts = line.Split();
                    string personName = parts[0];
                    string productName = parts[1];

                    if (persons.ContainsKey(personName))
                    {
                        if (products.ContainsKey(productName))
                        {
                            persons[personName].AddProduct(products[productName]);
                        }
                    }
                }

                foreach (var kvp in persons)
                {
                    if (kvp.Value.BagOfProducts.Count == 0)
                    {
                        Console.WriteLine($"{kvp.Key} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{kvp.Key} - {kvp.Value.ToString()}");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
