﻿namespace _03._Student_System
{
    public class Student
    {
        private string name;
        private int age;
        private double grade;

        public Student()
        {
        }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        private string GetGradeInfo()
        {
            if (this.Grade >= 5.00)
            {
                return "Excellent student.";
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                return "Average student.";
            }
            else
            {
                return "Very nice person.";
            }
        }

        public override string ToString()
        {
            return $"{this.Name} is {this.Age} years old. {GetGradeInfo()}";
        }
    }
}