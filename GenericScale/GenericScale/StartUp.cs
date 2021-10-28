using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equals = new EqualityScale<int>(1, 3);
            Console.WriteLine(equals.AreEqual());
        }
    }
}
