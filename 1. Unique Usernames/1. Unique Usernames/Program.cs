﻿using System;
using System.Collections.Generic;

namespace _1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                names.Add(line);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
