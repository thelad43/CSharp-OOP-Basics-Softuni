namespace _07._Food_Shortage.Models
{
    public class Citizen : Buyer
    {
        private readonly int age;
        private string id;

        public Citizen(string name, int age, string id, string birthDate)
            : base(birthDate, name)
        {
            this.age = age;
            this.Id = id;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}