namespace _07._Food_Shortage.Controllers
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private const string RebelBirthDate = "Unknown";

        internal void Run()
        {
            this.ProcessPeople();
        }

        private void ProcessPeople()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new List<Buyer>();

            for (int i = 0; i < n; i++)
            {
                var personData = Console.ReadLine().Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);

                if (personData.Length == 4)
                {
                    var id = personData[2];
                    var birthdate = personData[3];
                    people.Add(new Citizen(name, age, id, birthdate));
                }
                else
                {
                    var group = personData[2];
                    people.Add(new Rebel(RebelBirthDate, name, group));
                }
            }

            this.ProcessShopping(people);
            Console.WriteLine(people.Sum(p => p.Food));
        }

        private void ProcessShopping(List<Buyer> people)
        {
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                var buyer = people
                    .FirstOrDefault(p => p.Name == line);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }
        }
    }
}