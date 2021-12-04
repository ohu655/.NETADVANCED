using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            IPhonable stationaryPhone = new StationaryPhone();
            ISmartPhonable smartPhone = new SmartPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Calling(numbers[i]));                  
                }
                else
                {
                    Console.WriteLine(smartPhone.Calling(numbers[i]));                    
                }
            }

            for (int i = 0; i < websites.Length; i++)
            {
                Console.WriteLine(smartPhone.Browsing(websites[i]));                
            }
        }
    }
}
