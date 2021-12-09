using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10, 5);
            Console.WriteLine($"{rectangle.CalculateArea():f2}");
            Console.WriteLine($"{rectangle.CalculatePerimeters():f2}");
            Console.WriteLine(rectangle.Draw());

            Shape circle = new Circle(10);
            Console.WriteLine($"{circle.CalculatePerimeters():f2}");
            Console.WriteLine($"{circle.CalculateArea():f2}");
            Console.WriteLine(circle.Draw());
        }
    }
}
