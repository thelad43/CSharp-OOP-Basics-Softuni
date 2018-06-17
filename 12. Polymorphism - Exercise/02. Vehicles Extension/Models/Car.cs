namespace _02._Vehicles_Extension.Models
{
    using System;

    public class Car : Vehicle
    {
        private const double CarAirCondConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            var neededFuel = distance * (this.FuelConsumption + CarAirCondConsumption);

            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                var totalFuel = this.FuelQuantity + liters;

                if (totalFuel > this.TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += liters;
                }
            }
        }
    }
}