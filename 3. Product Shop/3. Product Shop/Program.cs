using System;
using System.Collections.Generic;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Revision")
                {
                    break;
                }

                string[] parts = line.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = parts[0];
                string product = parts[1];
                double price = double.Parse(parts[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop].Add(product, price);
                }
                

            }

            foreach (var kvp in shops)
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
