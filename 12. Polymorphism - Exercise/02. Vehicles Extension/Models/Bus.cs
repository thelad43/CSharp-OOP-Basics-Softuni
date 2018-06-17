namespace _02._Vehicles_Extension.Models
{
    using System;

    public class Bus : Vehicle
    {
        private const double BusAirCondConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            var neededFuel = distance * (this.FuelConsumption + BusAirCondConsumption);

            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

        public void DriveEmpty(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
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