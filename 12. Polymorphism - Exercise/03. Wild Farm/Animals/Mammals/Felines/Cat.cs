namespace _03._Wild_Farm.Animals.Mammals.Felines
{
    using Foods;

    public class Cat : Feline
    {
        private const double CatFoodPiece = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                Validator.ValidateEatableFood(this.GetType().Name, food.GetType().Name);
                this.FoodEaten = 0;
                return;
            }

            this.FoodEaten = food.Quantity;
            this.Weight += food.Quantity * CatFoodPiece;
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}