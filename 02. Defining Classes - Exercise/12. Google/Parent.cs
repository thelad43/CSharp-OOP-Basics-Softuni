namespace _12._Google
{
    using System;

    public class Parent
    {
        private string name;
        private string birthday;

        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Parent)}'s name can not be neither empty nor white space!!!");
                }

                this.name = value;
            }
        }

        public string Birthday
        {
            get
            {
                return this.birthday;
            }
            private set
            {
                this.birthday = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}";
        }
    }
}