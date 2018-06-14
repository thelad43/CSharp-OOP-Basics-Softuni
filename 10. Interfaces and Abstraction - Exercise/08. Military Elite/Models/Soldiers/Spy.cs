namespace _08._Military_Elite.Models.Soldiers
{
    using Interfaces;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
                .AppendLine($"Code Number: {this.CodeNumber}");

            return stringBuilder.ToString().Trim();
        }
    }
}