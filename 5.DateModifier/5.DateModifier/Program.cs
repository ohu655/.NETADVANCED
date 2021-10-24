using System;

namespace _5.DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.CalculateDate(firstDate, secondDate);

            Console.WriteLine(days);
        }
    }
}
