namespace _02._Animals
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var cat = new Cat("Pesho", "Whiskas");
            var dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}