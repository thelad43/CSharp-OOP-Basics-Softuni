namespace _03._Wild_Farm.Animals.Birds
{
    using Foods;

    public class Owl : Bird
    {
        private const double OwlFoodPiece = 0.25;

        public Owl(string name, double weight, double wingsSize)
            : base(name, weight, wingsSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Validator.ValidateEatableFood(this.GetType().Name, food.GetType().Name);
                this.FoodEaten = 0;
                return;
            }

            this.FoodEaten = food.Quantity;
            this.Weight += food.Quantity * OwlFoodPiece;
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingsSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}