using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();
            stack.Push("23");

            Console.WriteLine(stack.IsEmpty());
        }
    }
}
