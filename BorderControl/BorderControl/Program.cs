using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputInfo = input.Split();

                if (inputInfo.Length == 3)
                {
                    string name = inputInfo[0];
                    int age = int.Parse(inputInfo[1]);
                    string id = inputInfo[2];

                    IPerson robot = new Person(name, id);
                    persons.Add(robot);
                }
                else if (inputInfo.Length == 2)
                {
                    string model = inputInfo[0];
                    string id = inputInfo[1];

                    IPerson robot = new Person(model, id);
                    persons.Add(robot);
                }

                input = Console.ReadLine();
            }

            string digits = Console.ReadLine();


            foreach (var element in persons)
            {
                element.IsFake(digits);
            }
        }
    }
}
