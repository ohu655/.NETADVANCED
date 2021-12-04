using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                if (line.Length == 4)
                {
                    string name = line[0];
                    int age = int.Parse(line[1]);
                    string id = line[2];
                    string birthDate = line[3];

                    IBuyer citizen = new Citizen(name, age, id, birthDate);
                    buyers.Add(name, citizen);
                }
                else if (line.Length == 3)
                {
                    string name = line[0];
                    int age = int.Parse(line[1]);
                    string group = line[2];

                    IBuyer rebel = new Rebel(name, age, group);
                    buyers.Add(name, rebel);
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (buyers.ContainsKey(input))
                {
                    buyers[input].BuyFood();
                }

                input = Console.ReadLine();
            }

            int result = 0;

            foreach (var kvp in buyers)
            {
                result += kvp.Value.Food;
            }

            Console.WriteLine(result);
        }
    }
}
