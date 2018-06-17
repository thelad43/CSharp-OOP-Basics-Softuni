namespace _01._Vehicles
{
    public class Truck : Vehicle
    {
        private const double LostFuelWhenRefuling = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double airConditioningConsumption)
            : base(fuelQuantity, fuelConsumptionPerKm, airConditioningConsumption)
        {
        }

        public override void Refuel(double fuel)
        {
            fuel *= LostFuelWhenRefuling;
            base.Refuel(fuel);
        }
    }
}