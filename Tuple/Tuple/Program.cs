using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string name = firstLine[0] + " " + firstLine[1];
            string address = firstLine[2];
            string city = "";
            if (firstLine.Length == 4)
            {
                city = firstLine[3];
            }
            else
            {
                city = firstLine[3] + " " + firstLine[4];
            }
            

            TupleExample<string, string, string> tuple = new TupleExample<string, string, string>(name, address, city);
            Console.WriteLine(tuple.ToString());

            string[] secondLine = Console.ReadLine().Split();
            string firstName = secondLine[0];
            int litersOfBeer = int.Parse(secondLine[1]);
            bool drunkOrNot = true;

            if (secondLine[2] != "drunk")
            {
                drunkOrNot = false;
            }

            TupleExample<string, int, bool> tuple2 = new TupleExample<string, int, bool>(firstName, litersOfBeer, drunkOrNot);
            Console.WriteLine(tuple2.ToString());

            string[] thirdLine = Console.ReadLine().Split();
            string holderName = thirdLine[0];
            double floatNumber = double.Parse(thirdLine[1]);
            string bankName = thirdLine[2];
            TupleExample<string, double, string> tuple3 = new TupleExample<string, double, string>(holderName, floatNumber, bankName);
            Console.WriteLine(tuple3.ToString());
        }
    }
}
