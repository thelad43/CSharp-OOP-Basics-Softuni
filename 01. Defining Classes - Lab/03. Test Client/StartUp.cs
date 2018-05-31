namespace _03._Test_Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<BankAccount> bankAccounts;

        public static void Main()
        {
            bankAccounts = new List<BankAccount>();

            while (true)
            {
                var line = Console.ReadLine().Split();

                if (line[0] == "End")
                {
                    break;
                }

                try
                {
                    // switch on command
                    switch (line[0])
                    {
                        case "Create":
                            CreateAccount(int.Parse(line[1]));
                            break;

                        case "Deposit":
                            Deposit(int.Parse(line[1]), decimal.Parse(line[2]));
                            break;

                        case "Withdraw":
                            Withdraw(int.Parse(line[1]), decimal.Parse(line[2]));
                            break;

                        case "Print":
                            Print(int.Parse(line[1]));
                            break;

                        default:
                            throw new ArgumentException();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void Print(int id)
        {
            if (!AccountExists(id))
            {
                throw new InvalidOperationException("Account does not exist");
            }

            var acc = bankAccounts.Single(ba => ba.Id == id);
            Console.WriteLine(acc);
        }

        private static void Withdraw(int id, decimal amount)
        {
            if (!AccountExists(id))
            {
                throw new InvalidOperationException("Account does not exist");
            }

            var acc = bankAccounts.Single(ba => ba.Id == id);
            acc.Withdraw(amount);
        }

        private static void Deposit(int id, decimal amount)
        {
            if (!AccountExists(id))
            {
                throw new InvalidOperationException("Account does not exist");
            }

            var acc = bankAccounts.Single(ba => ba.Id == id);
            acc.Deposit(amount);
        }

        private static void CreateAccount(int id)
        {
            var acc = bankAccounts.SingleOrDefault(ba => ba.Id == id);

            if (acc == null)
            {
                bankAccounts.Add(new BankAccount(id));
            }
            else
            {
                throw new InvalidOperationException("Account already exists");
            }
        }

        private static bool AccountExists(int id)
        {
            var acc = new BankAccount(id);

            var exists = bankAccounts.Any(ba => ba.Id == acc.Id);

            return exists;
        }
    }
}