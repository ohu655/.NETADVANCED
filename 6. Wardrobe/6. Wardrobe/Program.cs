using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string color = parts[0];
                string[] typeOfClothe = parts[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < typeOfClothe.Length; j++)
                {
                    string cloth = typeOfClothe[j];

                    if (!clothes[color].ContainsKey(cloth))
                    {
                        clothes[color].Add(cloth, 1);
                    }
                    else
                    {
                        clothes[color][cloth] += 1;
                    }
                }
            }

            string find = Console.ReadLine();
            string[] findParts = find.Split();
            string findColor = findParts[0];
            string findClothe = findParts[1];

            foreach (var kvp in clothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var item in kvp.Value)
                {
                    if (kvp.Key == findColor && item.Key == findClothe)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
