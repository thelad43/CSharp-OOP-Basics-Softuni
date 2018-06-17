namespace _02._Vehicles_Extension.Models
{
    using System;

    public class Truck : Vehicle
    {
        private const double TruckAirCondConsumption = 1.6;
        private const double UsedFuel = 95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            var neededFuel = distance * (this.FuelConsumption + TruckAirCondConsumption);

            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
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
                var totalFuel = this.FuelQuantity + (liters * UsedFuel / 100.0);

                if (totalFuel > this.TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += (liters * UsedFuel / 100.0);
                }
            }
        }
    }
}