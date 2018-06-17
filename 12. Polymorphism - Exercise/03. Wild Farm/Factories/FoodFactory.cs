namespace _03._Wild_Farm.Factories
{
    using Foods;

    public class FoodFactory
    {
        public Food GetFood(string[] foodTokens)
        {
            var foodType = foodTokens[0];

            switch (foodType)
            {
                case "Fruit":
                    return new Fruit(int.Parse(foodTokens[1]));

                case "Meat":
                    return new Meat(int.Parse(foodTokens[1]));

                case "Seeds":
                    return new Seeds(int.Parse(foodTokens[1]));

                case "Vegetable":
                    return new Vegetable(int.Parse(foodTokens[1]));

                default:
                    return null;
            }
        }
    }
}