﻿namespace _08._Military_Elite.Models.Soldiers.Privates.SpecialisedSoldiers
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private IList<IRepair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, IEnumerable<IRepair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>(repairs);
        }

        IReadOnlyList<IRepair> IEngineer.Repairs
        {
            get
            {
                return this.repairs as IReadOnlyList<IRepair>;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine(base.ToString())
                .AppendLine("Repairs:")
                .Append(string.Join($"  {Environment.NewLine}", this.repairs.Select(r => $"  {r.ToString()}")));

            return stringBuilder.ToString().Trim();
        }
    }
}