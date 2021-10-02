using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {

            var passByContest = new Dictionary<string, string>();
            var userPoints = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of contests")
                {
                    break;
                }

                string[] parts = line.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = parts[0];
                string pass = parts[1];

                if (!passByContest.ContainsKey(contest))
                {
                    passByContest.Add(contest, pass);
                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of submissions")
                {
                    break;
                }

                string[] parts = line.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = parts[0];
                string pass = parts[1];
                string name = parts[2];
                int points = int.Parse(parts[3]);

                if (passByContest.ContainsKey(contest) && passByContest[contest] == pass)
                {
                    if (!userPoints.ContainsKey(name))
                    {
                        userPoints.Add(name, new Dictionary<string, int>());
                    }

                    if (userPoints[name].ContainsKey(contest))
                    {
                        if (userPoints[name][contest] < points)
                        {
                            userPoints[name][contest] = points;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        userPoints[name].Add(contest, points);
                    }                   
                }
                else
                {
                    continue;
                }
            }

            int maxSum = int.MinValue;
            string bestCandidate = string.Empty;

            foreach (var kvp in userPoints)
            {
                int sum = 0;
                string candidate = kvp.Key;

                foreach (var item in kvp.Value)
                {
                    sum += item.Value;
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestCandidate = candidate;
                }
                
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxSum} points.");
            Console.WriteLine("Ranking:");

            var sortedStudents = userPoints.OrderBy(n => n.Key);

            foreach (var kvp in sortedStudents)
            {
                Console.WriteLine(kvp.Key);

                foreach (var item in kvp.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
