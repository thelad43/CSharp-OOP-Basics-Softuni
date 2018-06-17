namespace _03._Wild_Farm.Animals.Birds
{
    using Foods;

    public class Hen : Bird
    {
        private const double HenFoodPiece = 0.35;

        public Hen(string name, double weight, double wingsSize)
            : base(name, weight, wingsSize)
        {
        }

        public override void Eat(Food food)
        {
            this.FoodEaten = food.Quantity;
            this.Weight += food.Quantity * HenFoodPiece;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingsSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}