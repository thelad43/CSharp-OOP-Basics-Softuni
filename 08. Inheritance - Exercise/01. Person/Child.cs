namespace _01._Person
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
            this.Age = age;
        }

        public new int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 14)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }

                base.Age = value;
            }
        }
    }
}