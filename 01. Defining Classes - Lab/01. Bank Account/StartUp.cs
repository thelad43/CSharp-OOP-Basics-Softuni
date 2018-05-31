namespace _01._Bank_Account
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var acc = new BankAccount(1, 50);

            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
        }
    }
}