namespace _02._Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var result = base.ExplainSelf() + Environment.NewLine + "DJAAF";
            return result;
        }
    }
}