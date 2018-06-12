namespace _06._Animals
{
    using Animals;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var animals = ReadAnimals();
            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }

        private static List<Animal> ReadAnimals()
        {
            var animals = new List<Animal>();

            while (true)
            {
                var kind = Console.ReadLine();

                if (kind == "Beast!")
                {
                    break;
                }

                var animalInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = animalInfo[0];
                var age = int.Parse(animalInfo[1]);
                var gender = animalInfo[2];

                try
                {
                    var animal = AnimalFactory.GetAnimal(kind, name, age, gender);
                    animals.Add(animal);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            return animals;
        }
    }
}