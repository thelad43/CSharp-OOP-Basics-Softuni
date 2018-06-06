namespace _04._Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Output")
                {
                    break;
                }

                var inputTokens = inputLine.Split();

                var department = inputTokens[0];
                var doctor = inputTokens[1] + " " + inputTokens[2];
                var patient = inputTokens[3];

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<string>();
                }

                departments[department].Add(patient);

                if (!doctors.ContainsKey(doctor))
                {
                    doctors[doctor] = new List<string>();
                }

                doctors[doctor].Add(patient);
            }

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var inputTokens = inputLine.Split();

                if (inputTokens.Length == 1)
                {
                    foreach (var patient in departments[inputLine])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else if (int.TryParse(inputTokens[1], out var result))
                {
                    if (int.Parse(inputTokens[1]) > 20)
                    {
                        continue;
                    }

                    var patients = departments[inputTokens[0]];
                    var room = patients.Skip(3 * (int.Parse(inputTokens[1]) - 1)).Take(3).OrderBy(p => p);

                    foreach (var patient in room)
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    var patients = doctors[inputLine];
                    patients.Sort();

                    foreach (var patient in patients)
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
        }
    }
}