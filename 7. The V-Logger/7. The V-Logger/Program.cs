using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string followers = "followers";
            string following = "following";

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Statistics")
                {
                    break;
                }

                string[] parts = line.Split();
                string name = parts[0];
                string command = parts[1];

                if (command != "followed")
                {
                    if (!vloggers.ContainsKey(name))
                    {
                        vloggers.Add(name, new Dictionary<string, HashSet<string>>());
                        vloggers[name].Add(following, new HashSet<string>());
                        vloggers[name].Add(followers, new HashSet<string>());
                    }
                }
                else
                {
                    string secondVlogger = parts[2];

                    if (vloggers.ContainsKey(name) && vloggers.ContainsKey(secondVlogger))
                    {
                        if (name != secondVlogger)
                        {
                            vloggers[name][following].Add(secondVlogger);
                            vloggers[secondVlogger][followers].Add(name);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var sorted = vloggers.OrderByDescending(n => n.Value[followers].Count).ThenBy(n => n.Value[following].Count);

            int count = 1;

            foreach (var currentVlogger in sorted)
            {
                Console.WriteLine($"{count}. {currentVlogger.Key} : {currentVlogger.Value[followers].Count} followers, {currentVlogger.Value[following].Count} following");

                if (count == 1)
                {
                    foreach (var item in currentVlogger.Value[followers].OrderBy(n => n))
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }

                count++;
            }
        }
    }
}
