using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "PARTY")
                {
                    break;                 
                }
                else
                {
                    guests.Add(line);
                }

               
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (guests.Contains(input))
                {
                    guests.Remove(input);
                }

                if (input == "END")
                {
                    break;
                }


            }
            Console.WriteLine(guests.Count);

            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();

                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
                
            }

            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();

                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
