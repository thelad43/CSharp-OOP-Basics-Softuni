namespace _07._Speed_Racing
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm,
            double distanceTraveled = 0)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.DistanceTraveled = distanceTraveled;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double DistanceTraveled { get; set; }

        public bool CanMoveDistance(double distance)
        {
            var neededFuel = this.FuelConsumptionPerKm * distance;

            if (this.FuelAmount >= neededFuel)
            {
                return true;
            }

            return false;
        }

        public double CalclulateUsedFuel(double distance)
        {
            return this.FuelConsumptionPerKm * distance;
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTraveled}";
        }
    }
}