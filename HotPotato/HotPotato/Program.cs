using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine()
                .Split();
            int step = int.Parse(Console.ReadLine());

            Queue<string> hotPotato = new Queue<string>();

            for (int i = 0; i < kids.Length; i++)
            {
                string kid = kids[i];

                hotPotato.Enqueue(kid);
            }

            while (hotPotato.Count > 1)
            {
                for (int i = 0; i < step - 1; i++)
                {
                    string potatoKid = hotPotato.Dequeue();
                    hotPotato.Enqueue(potatoKid);
                }

                string kidToLose = hotPotato.Dequeue();
                Console.WriteLine($"Removed {kidToLose}");
            }

            Console.WriteLine($"Last is {hotPotato.Dequeue()}");
        }
    }
}
