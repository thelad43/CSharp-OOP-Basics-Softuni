namespace _03._Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driverName, string model)
        {
            this.DriverName = driverName;
            this.Model = model;
        }

        public string Model { get; private set; }

        public string DriverName { get; private set; }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.UseBrakes()}/{this.PushGasPedal()}/{this.DriverName}";
        }
    }
}