namespace _02._Bank_Account_Methods
{
    using System;

    public class BankAccount
    {
        public BankAccount(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }

        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient balance");
            }

            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }
    }
}