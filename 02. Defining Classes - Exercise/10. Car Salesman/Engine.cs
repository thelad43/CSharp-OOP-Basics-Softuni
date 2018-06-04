namespace _10._Car_Salesman
{
    public class Engine
    {
        public Engine()
        {
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            return $"({this.Model}, {this.Power}, {this.Displacement}, {this.Efficiency})";
        }
    }
}