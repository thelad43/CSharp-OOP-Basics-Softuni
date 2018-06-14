namespace _08._Military_Elite.Models.Soldiers.Privates.SpecialisedSoldiers
{
    using Interfaces;
    using System;
    using System.Linq;
    using System.Text;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private readonly string[] possibleCorps = new string[] { "Airforces", "Marines" };

        private string corps;

        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }

            private set
            {
                if (!this.possibleCorps.Contains(value))
                {
                    throw new ArgumentException("Invalid Corps");
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine(base.ToString())
                .AppendLine($"Corps: {this.Corps}");

            return stringBuilder.ToString().Trim();
        }
    }
}