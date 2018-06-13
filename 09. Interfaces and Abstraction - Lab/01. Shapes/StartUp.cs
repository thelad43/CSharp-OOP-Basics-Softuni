namespace _01._Shapes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var radius = int.Parse(Console.ReadLine());
            var circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var rectangle = new Rectangle(width, height);

            circle.Draw();
            rectangle.Draw();
        }
    }
}