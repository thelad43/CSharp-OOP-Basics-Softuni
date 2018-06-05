namespace _01._Rhombus_of_Stars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            PrintRhombus(size);
        }

        private static void PrintRhombus(int size)
        {
            var spacesCount = size - 1;
            var starsCount = 1;

            // Print Upper Part
            for (int i = 0; i < size; i++)
            {
                Console.Write(new string(' ', spacesCount));

                for (int k = 0; k < starsCount; k++)
                {
                    Console.Write("* ");
                }

                spacesCount--;
                starsCount++;
                Console.WriteLine();
            }

            spacesCount = 1;
            starsCount--;

            // Print Lower Part
            for (int i = size; i > 0; i--)
            {
                Console.Write(new string(' ', spacesCount));

                for (int k = 0; k < starsCount - 1; k++)
                {
                    Console.Write("* ");
                }

                spacesCount++;
                starsCount--;
                Console.WriteLine();
            }
        }
    }
}