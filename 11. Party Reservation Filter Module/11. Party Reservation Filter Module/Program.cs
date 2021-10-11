using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            var dictionary = new Dictionary<string, Predicate<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Print")
                {
                    break;
                }

                string[] parts = line.Split(";");
                string action = parts[0];
                string predicateAction = parts[1];
                string value = parts[2];
                string key = predicateAction + "_" + value;

                if (action == "Add filter")
                {
                    Predicate<string> predicate = GetPredicate(predicateAction, value);
                    dictionary.Add(key, predicate);
                }
                else
                {
                    dictionary.Remove(key);
                }
            }

            foreach (var (key, predicate) in dictionary)
            {
                names.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", names));
        }

        private static Predicate<string> GetPredicate(string commandInfo, string parameter)
        {
            if (commandInfo == "Starts with")
            {
                return x => x.StartsWith(parameter);
            }

            if (commandInfo == "Ends with")
            {
                return x => x.EndsWith(parameter);
            }

            if (commandInfo == "Contains")
            {
                return x => x.Contains(parameter);
            }

            int lenght = int.Parse(parameter);

            return x => x.Length == lenght;
        }
    }
}
