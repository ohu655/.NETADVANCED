using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split();
                string name = parts[0];
                decimal grade = decimal.Parse(parts[1]);

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<decimal>());
                }

                grades[name].Add(grade);
            }

            foreach (var kvp in grades)
            {
                decimal sum = 0;

                foreach (var item in kvp.Value)
                {
                    sum += item;
                }

                decimal avg = sum / kvp.Value.Count;

                Console.Write($"{kvp.Key} -> ");

                foreach (var item in kvp.Value)
                {
                    Console.Write($"{item:f2} ");
                }

                Console.WriteLine($"(avg: {avg:f2})");
            }
        }
    }
}
