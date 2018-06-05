namespace _03._Student_System
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        public StudentSystem()
        {
            this.Students = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Students { get; private set; }

        public void ParseCommand()
        {
            var arguments = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (arguments[0] == "Create")
            {
                AddStudent(arguments);
            }
            else if (arguments[0] == "Show")
            {
                PrintStudent(arguments);
            }
            else if (arguments[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }

        private void PrintStudent(string[] arguments)
        {
            var name = arguments[1];

            if (this.Students.ContainsKey(name))
            {
                var student = this.Students[name];
                Console.WriteLine(student);
            }
        }

        private void AddStudent(string[] arguments)
        {
            var name = arguments[1];
            var age = int.Parse(arguments[2]);
            var grade = double.Parse(arguments[3]);

            if (!this.Students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                this.Students[name] = student;
            }
        }
    }
}