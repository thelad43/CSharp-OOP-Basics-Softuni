namespace _01._Raw_Data
{
    public class Cargo
    {
        public Cargo()
        {
        }

        public Cargo(double cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public string CargoType { get; set; }

        public double CargoWeight { get; set; }
    }
}