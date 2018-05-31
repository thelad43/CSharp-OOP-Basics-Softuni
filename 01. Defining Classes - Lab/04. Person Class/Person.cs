namespace _04._Person_Class
{
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, List<BankAccount> accounts)
            : this(name, age)
        {
            this.BankAccounts = accounts;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public List<BankAccount> BankAccounts { get; private set; }

        public decimal GetBalance()
        {
            return this.BankAccounts.Sum(b => b.Balance);
        }
    }
}