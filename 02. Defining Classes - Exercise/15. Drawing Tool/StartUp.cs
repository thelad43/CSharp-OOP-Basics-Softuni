namespace _15._Drawing_Tool
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var shape = Console.ReadLine();
            var drawningTool = new DrawingTool();

            if (shape == "Square")
            {
                var side = int.Parse(Console.ReadLine());
                var square = new Square(side);

                drawningTool.Draw(square);
            }
            else if (shape == "Rectangle")
            {
                var sideA = int.Parse(Console.ReadLine());
                var sideB = int.Parse(Console.ReadLine());
                var rectangle = new Rectangle(sideA, sideB);

                drawningTool.Draw(rectangle);
            }
        }
    }
}