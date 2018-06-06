namespace _01._Raw_Data
{
    public class Engine
    {
        public Engine()
        {
        }

        public Engine(double engineSpeed, double enginePower)
        {
            this.EnginePower = enginePower;
            this.EngineSpeed = engineSpeed;
        }

        public double EnginePower { get; set; }

        public double EngineSpeed { get; set; }
    }
}