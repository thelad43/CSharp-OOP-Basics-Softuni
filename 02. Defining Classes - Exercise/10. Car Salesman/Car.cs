namespace _10._Car_Salesman
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return $"Car: {this.Model}, Engine: {this.Engine}, Weight: {this.Weight}, Color: {this.Color}";
        }
    }
}