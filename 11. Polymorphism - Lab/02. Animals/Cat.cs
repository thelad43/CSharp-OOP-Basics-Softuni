namespace _02._Animals
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var result = base.ExplainSelf() + Environment.NewLine + "MEEOW";
            return result;
        }
    }
}