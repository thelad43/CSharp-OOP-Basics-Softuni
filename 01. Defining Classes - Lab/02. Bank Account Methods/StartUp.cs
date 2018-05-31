namespace _02._Bank_Account_Methods
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var acc = new BankAccount(1);

            acc.Deposit(50);
            acc.Withdraw(20);

            Console.WriteLine(acc);
        }
    }
}