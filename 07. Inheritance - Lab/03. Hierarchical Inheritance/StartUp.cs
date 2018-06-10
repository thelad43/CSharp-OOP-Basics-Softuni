namespace _03._Hierarchical_Inheritance
{
    public class StartUp
    {
        public static void Main()
        {
            var dog = new Dog();
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}