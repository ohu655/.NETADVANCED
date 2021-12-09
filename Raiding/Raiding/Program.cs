using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBaseHero> heroes = new List<IBaseHero>();

            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (n != counter)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == "Druid")
                {
                    IBaseHero druid = new Druid(name);
                    heroes.Add(druid);
                    counter++;
                }
                else if (type == "Paladin")
                {
                    IBaseHero paladin = new Paladin(name);
                    heroes.Add(paladin);
                    counter++;
                }
                else if (type == "Rogue")
                {
                    IBaseHero rogue = new Rogue(name);
                    heroes.Add(rogue);
                    counter++;
                }
                else if (type == "Warrior")
                {
                    IBaseHero warrior = new Warrior(name);
                    heroes.Add(warrior);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            long bossPower = long.Parse(Console.ReadLine());
            long heroesPower = 0;

            foreach (var hero in heroes)
            {
                heroesPower += hero.Power;
                Console.WriteLine(hero.CastAbility());
            }

            if (heroesPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
