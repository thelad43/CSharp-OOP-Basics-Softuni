namespace _04._Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new List<Person>(n);

            for (int i = 0; i < n; i++)
            {
                // {name} {age}
                var tokens = Console.ReadLine().Split();
                people.Add(new Person(tokens[0], int.Parse(tokens[1])));
            }

            people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .Select(p => $"{p.Name} - {p.Age}")
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}