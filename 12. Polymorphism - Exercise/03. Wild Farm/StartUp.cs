namespace _03._Wild_Farm
{
    using Animals;
    using Factories;
    using Foods;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<Animal>();
            var foods = new List<Food>();

            ReadInput(animals, foods);

            ProcessAnimalProducingSounds(animals);
            ProcessAnimalEating(animals, foods);

            PrintAnimals(animals);
        }

        private static void PrintAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static void ProcessAnimalEating(List<Animal> animals, List<Food> foods)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].Eat(foods[i]);
            }
        }

        private static void ProcessAnimalProducingSounds(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ProduceSound());
            }
        }

        private static void ReadInput(List<Animal> animals, List<Food> foods)
        {
            var animalFactory = new AnimalFactory();
            var foodFactory = new FoodFactory();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var animalTokens = inputLine
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var foodTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var animal = animalFactory.GetAnimal(animalTokens);
                var food = foodFactory.GetFood(foodTokens);

                animals.Add(animal);
                foods.Add(food);
            }
        }
    }
}