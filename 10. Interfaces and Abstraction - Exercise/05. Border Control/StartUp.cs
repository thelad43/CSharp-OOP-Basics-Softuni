namespace _05._Border_Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allIds = new HashSet<string>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                var lineTokens = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var id = lineTokens.LastOrDefault();
                allIds.Add(id);
            }

            var endingPartOfFakeId = Console.ReadLine();

            var detainedIds = allIds
                .Where(id => id.EndsWith(endingPartOfFakeId))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, detainedIds));
        }
    }
}