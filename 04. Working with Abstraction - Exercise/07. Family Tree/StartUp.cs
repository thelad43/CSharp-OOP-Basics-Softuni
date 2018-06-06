namespace _07._Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var searchedPerson = Console.ReadLine();
            var people = new List<Person>();
            GetData(people);
            PrintParentsAndChildren(people, searchedPerson);
        }

        private static void PrintParentsAndChildren(List<Person> allPeople, string searchedPersonParam)
        {
            var person = allPeople.FirstOrDefault(p => (searchedPersonParam.Contains("/"))
                ? p.BirthDate == searchedPersonParam
                : p.Name == searchedPersonParam);

            var result = new StringBuilder();
            result.AppendLine($"{person.Name} {person.BirthDate}");
            result.AppendLine("Parents:");

            foreach (var parent in allPeople.Where(p => p.FindChildName(person.Name) != null))
            {
                result.AppendLine($"{parent.Name} {parent.BirthDate}");
            }

            result.AppendLine("Children:");

            foreach (var child in allPeople.FirstOrDefault(p => p.Name == person.Name).Children)
            {
                result.AppendLine($"{child.Name} {child.BirthDate}");
            }

            Console.WriteLine(result);
        }

        private static void GetData(List<Person> people)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                if (inputLine.Contains("-"))
                {
                    var tokens = inputLine
                        .Split('-')
                        .Select(x => x.Trim())
                        .ToArray();

                    var parentParam = tokens[0];
                    var childParam = tokens[1];

                    var parent = people
                        .FirstOrDefault(p => parentParam.Contains("/") ?
                        p.BirthDate == parentParam : p.Name == parentParam);

                    if (parent == null)
                    {
                        parent = parentParam.Contains("/") ?
                            new Person { BirthDate = parentParam } : new Person { Name = parentParam };

                        people.Add(parent);
                    }

                    var child = childParam.Contains("/") ?
                        new Person { BirthDate = childParam } : new Person { Name = childParam };

                    parent.AddChild(child);
                }
                else
                {
                    var tokens = inputLine.Split(' ');
                    var name = $"{tokens[0]} {tokens[1]}";
                    var date = tokens[2];
                    var isAdded = false;

                    for (int i = 0; i < people.Count; i++)
                    {
                        if (people[i].Name == name)
                        {
                            people[i].BirthDate = date;
                            isAdded = true;
                        }

                        if (people[i].BirthDate == date)
                        {
                            people[i].Name = name;
                            isAdded = true;
                        }

                        people[i].AddChildrenInfo(name, date);
                    }

                    if (!isAdded)
                    {
                        people.Add(new Person(name, date));
                    }
                }
            }
        }
    }
}