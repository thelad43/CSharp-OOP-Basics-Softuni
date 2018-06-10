namespace _05._Pizza_Calories
{
    using Ingredients;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                while (true)
                {
                    var inputTokens = Console.ReadLine().Split();

                    switch (inputTokens[0].ToLower())
                    {
                        case "pizza":
                            var pizza = SetPizza(inputTokens[1]);
                            Console.WriteLine(pizza.GetTotalCalories());
                            return;

                        case "dough":
                            var dough = new Dough(inputTokens[1], inputTokens[2], int.Parse(inputTokens[3]));
                            Console.WriteLine($"{dough.GetCalories():F2}");
                            break;

                        case "topping":
                            var topping = new Topping(inputTokens[1], int.Parse(inputTokens[2]));
                            Console.WriteLine($"{topping.GetCalories():F2}");
                            break;

                        default:
                            throw new ArgumentException();
                    }
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static Pizza SetPizza(string name)
        {
            var doughTypeTechnique = Console.ReadLine().Split();

            var pizza = new Pizza(name)
            {
                Dough = new Dough(doughTypeTechnique[1], doughTypeTechnique[2], int.Parse(doughTypeTechnique[3]))
            };

            while (true)
            {
                var toppingData = Console.ReadLine().Split();

                if (toppingData[0] == "END")
                {
                    break;
                }

                pizza.AddTopping(new Topping(toppingData[1], int.Parse(toppingData[2])));
            }

            return pizza;
        }
    }
}