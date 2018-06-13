namespace _02._Cars.Cars
{
    using Interfaces;
    using System;

    public class Tesla : IElectricCar
    {
        private string model;
        private string color;
        private int batteries;

        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = batteries;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or white space!");
                }

                this.model = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Color cannot be null or white space!");
                }

                this.color = value;
            }
        }

        public int Batteries
        {
            get
            {
                return this.batteries;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Batteries cannot be less than 1!");
                }

                this.batteries = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} {nameof(Tesla)} {this.Model} with {this.Batteries} Batteries{Environment.NewLine}{this.Start()}{Environment.NewLine}{this.Stop()}";
        }
    }
}