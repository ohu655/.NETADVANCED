using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Party!")
                {
                    break;
                }
                
                string[] parts = line.Split();
                string command = parts[0];
                string commandInfo = parts[1];

                Predicate<string> predicate = GetPredicate(commandInfo, parts[2]);

                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else if (command == "Double")
                {
                    List<string> names = guests.FindAll(predicate);

                    if (names.Any())
                    {
                        int index = names.FindIndex(predicate);
                        guests.InsertRange(index, names);
                    }
                }

            }

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string commandInfo, string parameter)
        {
            if (commandInfo == "StartsWith")
            {
                return x => x.StartsWith(parameter);
            }

            if (commandInfo == "EndsWith")
            {
                return x => x.EndsWith(parameter);
            }

            int lenght = int.Parse(parameter);

            return x => x.Length == lenght;
        }
    }
}
