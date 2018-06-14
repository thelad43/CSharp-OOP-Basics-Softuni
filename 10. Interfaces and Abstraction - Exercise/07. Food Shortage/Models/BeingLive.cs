namespace _07._Food_Shortage.Models
{
    using Interfaces;

    public abstract class BeingLive : IBirthable
    {
        public BeingLive(string birthDate, string name)
        {
            this.BirthDate = birthDate;
            this.Name = name;
        }

        public string BirthDate { get; private set; }

        public string Name { get; private set; }
    }
}