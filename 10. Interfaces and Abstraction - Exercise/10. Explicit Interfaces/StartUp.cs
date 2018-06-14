namespace _10._Explicit_Interfaces
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var citizens = ReadCitizens();
            PrintNames(citizens);
        }

        private static void PrintNames(List<Citizen> citizens)
        {
            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }

        private static List<Citizen> ReadCitizens()
        {
            var citizens = new List<Citizen>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var citizenInfo = inputLine
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = citizenInfo[0];
                var country = citizenInfo[1];
                var age = int.Parse(citizenInfo[2]);

                var citizen = new Citizen(name, country, age);
                citizens.Add(citizen);
            }

            return citizens;
        }
    }
}