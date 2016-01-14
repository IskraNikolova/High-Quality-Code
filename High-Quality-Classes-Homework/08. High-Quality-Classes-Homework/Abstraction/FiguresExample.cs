namespace Abstraction
{
    using System;
    using Models;

    public class FiguresExample
    {
        public static void Main()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            Console.WriteLine(circle);

            double width = 2;
            double height = 3;
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine(rectangle);          
        }
    }
}
