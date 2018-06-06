namespace _03._Jedi_Galaxy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var matrix = ReadMatrix();
            var stars = CollectStars(matrix);
            Console.WriteLine(stars);
        }

        private static long CollectStars(int[][] matrix)
        {
            var collectedStars = 0L;

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Let the Force be with you")
                {
                    break;
                }

                var ivoPosition = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var evilPosition = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                EvilMoove(matrix, evilPosition);
                collectedStars += IvoMoove(matrix, ivoPosition);
            }

            return collectedStars;
        }

        private static long IvoMoove(int[][] matrix, int[] ivoPosition)
        {
            var stars = 0L;

            while (ivoPosition[0] >= 0 && ivoPosition[1] < matrix[0].Length)
            {
                if (IsInMatrix(matrix, ivoPosition))
                {
                    stars += matrix[ivoPosition[0]][ivoPosition[1]];
                }

                ivoPosition[0]--;
                ivoPosition[1]++;
            }

            return stars;
        }

        private static void EvilMoove(int[][] matrix, int[] evilPosition)
        {
            while (evilPosition[0] >= 0 && evilPosition[1] >= 0)
            {
                if (IsInMatrix(matrix, evilPosition))
                {
                    matrix[evilPosition[0]][evilPosition[1]] = 0;
                }

                evilPosition[0]--;
                evilPosition[1]--;
            }
        }

        private static bool IsInMatrix(int[][] matrix, int[] position)
        {
            return position[0] >= 0 && position[1] >= 0 && position[0] < matrix.Length &&
                position[1] < matrix[position[0]].Length;
        }

        private static int[][] ReadMatrix()
        {
            var dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[dimensions[0]][];
            var cellValue = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[dimensions[1]];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = cellValue;
                    cellValue++;
                }
            }

            return matrix;
        }
    }
}