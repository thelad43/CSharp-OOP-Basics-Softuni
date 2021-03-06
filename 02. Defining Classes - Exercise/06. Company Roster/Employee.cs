﻿namespace _06._Company_Roster
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string name, decimal salary, string position,
            string department, string email = "n/a", int age = -1)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Salary:F2} {this.Email} {this.Age}";
        }
    }
}