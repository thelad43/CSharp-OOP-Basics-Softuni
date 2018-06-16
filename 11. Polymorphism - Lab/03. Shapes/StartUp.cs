namespace _03._Shapes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var radius = double.Parse(Console.ReadLine());
            var circle = new Circle(radius);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
            Console.WriteLine();

            var height = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var rectangle = new Rectangle(height, width);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}