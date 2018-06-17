namespace _03._Wild_Farm.Animals.Birds
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingsSize)
            : base(name, weight)
        {
            this.WingsSize = wingsSize;
        }

        public double WingsSize { get; set; }
    }
}