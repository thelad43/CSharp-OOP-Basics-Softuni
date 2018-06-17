namespace _02._Vehicles_Extension
{
    using System;

    public static class Validator
    {
        public static void ValidateFuel(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
        }
    }
}