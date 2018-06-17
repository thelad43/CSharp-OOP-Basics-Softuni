namespace _03._Wild_Farm.Animals.Mammals.Felines
{
    using Foods;

    public class Tiger : Feline
    {
        private const double TigerFoodPiece = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
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
            this.Weight += food.Quantity * TigerFoodPiece;
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}