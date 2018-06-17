namespace _03._Wild_Farm.Animals.Mammals
{
    using Foods;

    public class Mouse : Mammal
    {
        private const double MouseFoodPiece = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
            {
                Validator.ValidateEatableFood(this.GetType().Name, food.GetType().Name);
                this.FoodEaten = 0;
                return;
            }

            this.FoodEaten = food.Quantity;
            this.Weight += food.Quantity * MouseFoodPiece;
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}