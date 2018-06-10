namespace _04._Random_List
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        private Random random = new Random();

        public string RandomString()
        {
            var randomIndex = this.random.Next(0, this.Count - 1);
            var removedItem = this[randomIndex];
            this.RemoveAt(randomIndex);
            return removedItem;
        }
    }
}