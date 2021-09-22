using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int value = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksInput);
            Stack<int> bullets = new Stack<int>(bulletsInput);
            int shootedBullets = 0;

            while (true)
            {

                if (!locks.Any())
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${value}");
                    return;
                }

                if (!bullets.Any())
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }

                int currentBullet = bullets.Peek();
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                    shootedBullets++;
                    value -= priceOfBullet;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    shootedBullets++;
                    value -= priceOfBullet;
                }      

                if (shootedBullets == sizeOfGunBarrel)
                {
                    if (bullets.Count != 0)
                    {
                        Console.WriteLine("Reloading!");
                        shootedBullets = 0;
                    }
                    
                }
            }

        }
    }
}
