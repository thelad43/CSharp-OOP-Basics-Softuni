namespace _05._Pizza_Calories.Ingredients
{
    using System;

    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        private const int CaloriesPerGram = 2;
        private const double MeatModifier = 1.2;
        private const double VeggiesModifier = 0.8;
        private const double CheeseModifier = 1.1;
        private const double SauceModifier = 0.9;

        private string type;
        private int weightInGrams;

        public Topping(string type, int weightInGrams)
        {
            this.Type = type;
            this.WeightInGrams = weightInGrams;
        }

        private int WeightInGrams
        {
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weightInGrams = value;
            }
        }

        private string Type
        {
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double GetCalories()
        {
            var calories = 1D * this.weightInGrams * CaloriesPerGram;

            switch (this.type.ToLower())
            {
                case "meat":
                    calories *= MeatModifier;
                    break;

                case "veggies":
                    calories *= VeggiesModifier;
                    break;

                case "cheese":
                    calories *= CheeseModifier;
                    break;

                case "sauce":
                    calories *= SauceModifier;
                    break;

                default:
                    throw new ArgumentException();
            }

            return calories;
        }
    }
}