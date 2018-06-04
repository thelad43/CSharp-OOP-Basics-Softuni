namespace _12._Google
{
    public class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get; private set; }

        public int Speed { get; private set; }

        public override string ToString()
        {
            return $"{this.Model} {this.Speed}";
        }
    }
}