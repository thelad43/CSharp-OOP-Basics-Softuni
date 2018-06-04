namespace _12._Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = GetPeople();
            PrintPeople(people);
        }

        private static void PrintPeople(Queue<Person> people)
        {
            var personToPrint = Console.ReadLine();

            var person = people
                .FirstOrDefault(p => p.Name == personToPrint);

            if (person != null)
            {
                Console.Write(person.ToString());
            }
        }

        private static Queue<Person> GetPeople()
        {
            var people = new Queue<Person>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var inputParams = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var personName = inputParams[0];
                var person = people.FirstOrDefault(p => p.Name == personName);

                if (person == null)
                {
                    person = new Person(personName);
                    people.Enqueue(person);
                }

                OrderData(person, inputParams);
            }

            return people;
        }

        private static void OrderData(Person person, string[] arguments)
        {
            switch (arguments[1])
            {
                case "company":
                    var companyName = arguments[2];
                    var salary = decimal.Parse(arguments[4]);
                    var department = arguments[3];
                    person.AssignACompany(new Company(companyName, salary, department));
                    break;

                case "pokemon":
                    var pokemonName = arguments[2];
                    var type = arguments[3];
                    person.AddInCollection(new Pokemon(pokemonName, type));
                    break;

                case "parents":
                    var parentName = arguments[2];
                    var parentBirthDay = arguments[3];
                    person.AddInCollection(new Parent(parentName, parentBirthDay));
                    break;

                case "children":
                    var childName = arguments[2];
                    var childBirthDay = arguments[3];
                    person.AddInCollection(new Child(childName, childBirthDay));
                    break;

                case "car":
                    var model = arguments[2];
                    var speed = int.Parse(arguments[3]);
                    person.AssignACar(new Car(model, speed));
                    break;
            }
        }
    }
}