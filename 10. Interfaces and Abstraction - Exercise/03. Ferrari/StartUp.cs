namespace _03._Ferrari
{
    using System;

    public class StartUp
    {
        private const string Model = "488-Spider";

        public static void Main()
        {
            var name = Console.ReadLine();
            var ferrari = new Ferrari(name, Model);
            Console.WriteLine(ferrari);
        }
    }
}