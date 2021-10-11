using System;
using System.Linq;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Predicate<string> nameLenght = name => name.Length <= number;

            var result = names.Where(x => nameLenght(x));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
