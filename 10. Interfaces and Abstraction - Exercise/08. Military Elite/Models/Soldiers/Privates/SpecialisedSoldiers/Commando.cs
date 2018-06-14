namespace _08._Military_Elite.Models.Soldiers.Privates.SpecialisedSoldiers
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private IList<IMission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps, IEnumerable<IMission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>(missions);
        }

        public IReadOnlyList<IMission> Missions
        {
            get
            {
                return this.missions as IReadOnlyList<IMission>;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString())
                .AppendLine("Missions:")
                .Append("  ")
                .Append(string.Join($"  {Environment.NewLine}", this.missions.Select(m => $"  {m.ToString()}")));

            return stringBuilder.ToString().Trim();
        }
    }
}