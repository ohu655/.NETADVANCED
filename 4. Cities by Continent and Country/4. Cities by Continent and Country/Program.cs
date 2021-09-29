using System;
using System.Collections.Generic;

namespace _4._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split();
                string continent = parts[0];
                string country = parts[1];
                string city = parts[2];

                if (!cities.ContainsKey(continent))
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());

                }
                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent].Add(country, new List<string>());
                }

                cities[continent][country].Add(city);

            }

            foreach (var kvp in cities)
            {
                Console.WriteLine($"{kvp.Key}: ");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
