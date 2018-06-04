namespace _12._Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private Queue<Parent> parents;
        private Queue<Child> children;
        private Queue<Pokemon> pokemons;

        public Person()
        {
        }

        public Person(string name)
        {
            this.Name = name;
            this.Parents = new Queue<Parent>();
            this.Children = new Queue<Child>();
            this.Pokemons = new Queue<Pokemon>();
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
                    throw new ArgumentException($"{nameof(Person)}'s name can not be neither empty nor white space!!!");
                }

                this.name = value;
            }
        }

        public Company Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public Car Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }

        public Queue<Parent> Parents
        {
            get
            {
                return this.parents;
            }
            set
            {
                this.parents = value;
            }
        }

        public Queue<Child> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                this.children = value;
            }
        }

        public Queue<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

        public void AssignACompany(Company company)
        {
            this.Company = company;
        }

        public void AssignACar(Car car)
        {
            this.Car = car;
        }

        public void AddInCollection(Pokemon pokemon)
        {
            this.Pokemons.Enqueue(pokemon);
        }

        public void AddInCollection(Parent parent)
        {
            this.Parents.Enqueue(parent);
        }

        public void AddInCollection(Child child)
        {
            this.Children.Enqueue(child);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.name);
            sb.AppendLine("Company:");

            if (this.Company != null)
            {
                sb.AppendLine(this.Company.ToString());
            }

            sb.AppendLine("Car:");

            if (this.Car != null)
            {
                sb.AppendLine(this.Car.ToString());
            }

            sb.AppendLine("Pokemon:");

            if (this.Pokemons.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.Pokemons.Select(pok => pok.ToString())));
            }

            sb.AppendLine("Parents:");

            if (this.Parents.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.Parents.Select(par => par.ToString())));
            }

            sb.AppendLine("Children:");

            if (this.Children.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.Children.Select(c => c.ToString())));
            }

            return sb.ToString();
        }
    }
}