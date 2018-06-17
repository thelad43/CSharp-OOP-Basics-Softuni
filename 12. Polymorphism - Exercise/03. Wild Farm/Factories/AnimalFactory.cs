namespace _03._Wild_Farm.Factories
{
    using Animals;
    using Animals.Birds;
    using Animals.Mammals;
    using Animals.Mammals.Felines;

    public class AnimalFactory
    {
        public Animal GetAnimal(string[] animalTokens)
        {
            var animalType = animalTokens[0];

            switch (animalType)
            {
                case "Hen":
                    return new Hen(animalTokens[1], double.Parse(animalTokens[2]), double.Parse(animalTokens[3]));

                case "Owl":
                    return new Owl(animalTokens[1], double.Parse(animalTokens[2]), double.Parse(animalTokens[3]));

                case "Mouse":
                    return new Mouse(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);

                case "Dog":
                    return new Dog(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);

                case "Cat":
                    return new Cat(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);

                case "Tiger":
                    return new Tiger(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);

                default:
                    return null;
            }
        }
    }
}