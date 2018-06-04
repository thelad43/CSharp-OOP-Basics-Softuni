namespace _09._Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rectangles = SetRectangles(inputTokens[0]);

            CheckIntersections(inputTokens[1], rectangles);
        }

        private static void CheckIntersections(int numberOfIntersectionChecks, Queue<Rectangle> rectangles)
        {
            while (numberOfIntersectionChecks > 0)
            {
                var pair = Console.ReadLine().Split();
                var firstRect = rectangles.Where(r => r.Id == pair[0]).FirstOrDefault();
                var secondRect = rectangles.Where(r => r.Id == pair[1]).FirstOrDefault();
                Console.WriteLine(firstRect.HasIntersect(secondRect) ? "true" : "false");
                numberOfIntersectionChecks--;
            }
        }

        private static Queue<Rectangle> SetRectangles(int numberOfRectangles)
        {
            var rectangles = new Queue<Rectangle>(numberOfRectangles);

            while (rectangles.Count < numberOfRectangles)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                rectangles.Enqueue(new Rectangle(input[0], double.Parse(input[1]),
                    double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4])));
            }

            return rectangles;
        }
    }
}