namespace _03._Wild_Farm
{
    using System;

    public static class Validator
    {
        public static void ValidateEatableFood(string type, string foodType)
        {
            Console.WriteLine($"{type} does not eat {foodType}!");
        }
    }
}