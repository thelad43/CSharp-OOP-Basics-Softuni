namespace _05._Date_Modifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var diff = DateModifier.CalculateDifference(firstDate, secondDate);
            Console.WriteLine(Math.Abs(diff));
        }
    }
}