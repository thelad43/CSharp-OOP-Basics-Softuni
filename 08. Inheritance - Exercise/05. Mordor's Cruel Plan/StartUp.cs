namespace _05._Mordor_s_Cruel_Plan
{
    using Factories;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var player = new Player();

            player.Eat(Console.ReadLine()
                .Split()
                .Where(fn => fn != string.Empty)
                .Select(fn => FoodFactory.GetFood(fn)));

            Console.WriteLine(player);
        }
    }
}