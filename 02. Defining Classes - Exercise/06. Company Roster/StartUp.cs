namespace _06._Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var employees = ReadEmployees(n);
            var department = GetDepartmentWithHighestAverageSalary(employees);
            PrintResult(department, employees);
        }

        private static void PrintResult(string department, List<Employee> employees)
        {
            Console.WriteLine($"Highest Average Salary: {department}");

            Console.WriteLine(string
                .Join(Environment.NewLine, employees
                .Where(e => e.Department == department)
                .OrderByDescending(e => e.Salary)
                .ToList()));
        }

        private static string GetDepartmentWithHighestAverageSalary(List<Employee> employees)
        {
            var dictionary = new Dictionary<string, List<decimal>>();

            foreach (var empl in employees)
            {
                if (!dictionary.ContainsKey(empl.Department))
                {
                    dictionary[empl.Department] = new List<decimal>();
                }

                dictionary[empl.Department].Add(empl.Salary);
            }

            var maxAverage = decimal.MinValue;
            var result = string.Empty;

            foreach (var kvp in dictionary)
            {
                var currentAverageSalary = kvp.Value.Average();

                if (currentAverageSalary > maxAverage)
                {
                    maxAverage = currentAverageSalary;
                    result = kvp.Key;
                }
            }

            return result;
        }

        private static List<Employee> ReadEmployees(int n)
        {
            var employees = new List<Employee>(n);

            for (int i = 0; i < n; i++)
            {
                var lineTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = lineTokens[0];
                var salary = decimal.Parse(lineTokens[1]);
                var position = lineTokens[2];
                var department = lineTokens[3];
                var email = "n/a";
                var age = -1;

                if (lineTokens.Length == 5)
                {
                    if (!int.TryParse(lineTokens[4], out age))
                    {
                        email = lineTokens[4];
                        age = -1;
                    }
                }
                else if (lineTokens.Length == 6)
                {
                    email = lineTokens[4];
                    age = int.Parse(lineTokens[5]);
                }

                var employee = new Employee(name, salary, position, department, email, age);
                employees.Add(employee);
            }

            return employees;
        }
    }
}