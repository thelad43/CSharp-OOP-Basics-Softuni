namespace _02._Cars.Cars
{
    using Interfaces;
    using System;

    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
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
            return $"{this.Color} {nameof(Seat)} {this.Model}{Environment.NewLine}Engine start{Environment.NewLine}Breaaak!";
        }
    }
}