using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> stringStates = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                string command = line[0];

                if (command == "1")
                {
                    stringStates.Push(sb.ToString());
                    string text = line[1];
                    sb.Append(text);     

                }
                else if (command == "2")
                {
                    int count = int.Parse(line[1]);

                    stringStates.Push(sb.ToString());
                    while (count > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        count--;
                    }                   
                }
                else if (command == "3")
                {
                    int index = int.Parse(line[1]);

                    Console.WriteLine(sb[index - 1]);
                }
                else
                {
                    sb.Clear();
                    sb.Append(stringStates.Pop());
                }
            }
        }
    }
}
