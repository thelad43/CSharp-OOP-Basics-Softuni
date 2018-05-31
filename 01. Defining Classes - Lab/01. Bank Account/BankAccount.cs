namespace _01._Bank_Account
{
    public class BankAccount
    {
        public BankAccount(int id, decimal balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        public int Id { get; private set; }

        public decimal Balance { get; private set; }
    }
}