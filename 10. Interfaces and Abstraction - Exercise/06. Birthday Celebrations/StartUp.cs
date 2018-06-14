namespace _06._Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allYears = new Queue<string>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                var lineTokens = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!lineTokens[0].StartsWith("Robot"))
                {
                    var year = lineTokens.LastOrDefault();
                    allYears.Enqueue(year);
                }
            }

            var wantedYear = Console.ReadLine();

            var result = allYears
                .Where(y => y.EndsWith(wantedYear))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}