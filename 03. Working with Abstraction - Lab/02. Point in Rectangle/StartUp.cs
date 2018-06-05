namespace _02._Point_in_Rectangle
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var rectangle = ReadRectangle();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var point = ReadPoint();
                var contains = rectangle.Contains(point) ? true : false;
                Console.WriteLine(contains);
            }
        }

        private static Point ReadPoint()
        {
            // <X> <Y>
            var inputTokens = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            var point = new Point(inputTokens[0], inputTokens[1]);
            return point;
        }

        private static Rectangle ReadRectangle()
        {
            // <topLeftX> <topLeftY> <bottomRightX> <bottomRightY>
            var inputTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var topLeftX = inputTokens[0];
            var topLeftY = inputTokens[1];
            var bottomRightX = inputTokens[2];
            var bottomRightY = inputTokens[3];

            var topLeftPoint = new Point(topLeftX, topLeftY);
            var bottomRightPoint = new Point(bottomRightX, bottomRightY);

            var rectangle = new Rectangle(topLeftPoint, bottomRightPoint);
            return rectangle;
        }
    }
}