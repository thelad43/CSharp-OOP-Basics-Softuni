namespace _08._Raw_Data
{
    public class Tire
    {
        public Tire()
        {
        }

        public Tire(double tirePressure, int tireAge)
        {
            this.TireAge = tireAge;
            this.TirePressure = tirePressure;
        }

        public int TireAge { get; set; }

        public double TirePressure { get; set; }
    }
}