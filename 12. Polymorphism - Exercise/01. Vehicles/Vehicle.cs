namespace _01._Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double airConditioningConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double airConditioningConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.airConditioningConsumption = airConditioningConsumption;
        }

        public virtual void Refuel(double fuel)
        {
            this.fuelQuantity += fuel;
        }

        public string Drive(double distance)
        {
            var neededFuel = distance * (this.fuelConsumptionPerKm + this.airConditioningConsumption);

            if (this.fuelQuantity < neededFuel)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.fuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
        }
    }
}