namespace _04._Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var sites = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var smartphone = new Smartphone();

            // Call
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(smartphone.Call(numbers[i]));
            }

            if (sites.Any())
            {
                // Browse
                for (int i = 0; i < sites.Length; i++)
                {
                    Console.WriteLine(smartphone.Browse(sites[i]));
                }
            }
            else
            {
                Console.WriteLine("Browsing: !");
            }
        }
    }
}