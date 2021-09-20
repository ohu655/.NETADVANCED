using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parenheses = new Stack<char>();

            bool isBalanced = true;

            foreach (var element in input)
            {
                if (element == '(' ||
                    element == '{' ||
                    element == '[')
                {
                    parenheses.Push(element);
                }
                else
                {
                    if (parenheses.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    if (element == ')' && parenheses.Peek() == '(')
                    {
                        parenheses.Pop();
                    }
                    else if (element == '}' && parenheses.Peek() == '{')
                    {
                        parenheses.Pop();
                    }
                    else if (element == ']' && parenheses.Peek() == '[')
                    {
                        parenheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
              
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
