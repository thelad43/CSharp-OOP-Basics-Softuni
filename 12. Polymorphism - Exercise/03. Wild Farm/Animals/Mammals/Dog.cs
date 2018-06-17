namespace _03._Wild_Farm.Animals.Mammals
{
    using Foods;

    public class Dog : Mammal
    {
        private const double DogFoodPiece = 0.40;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
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
            this.Weight += food.Quantity * DogFoodPiece;
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}