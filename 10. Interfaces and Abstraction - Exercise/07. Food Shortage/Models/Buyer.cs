namespace _07._Food_Shortage.Models
{
    using Interfaces;

    public abstract class Buyer : BeingLive, IBuyer
    {
        public Buyer(string birthDate, string name)
            : base(birthDate, name)
        {
        }

        public int Food { get; protected set; }

        public abstract void BuyFood();
    }
}