namespace _05._Stack_of_Strings
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings : IEnumerable
    {
        private List<string> data = new List<string>();

        public void Push(string item)
        {
            this.data.Add(item);
        }

        public string Pop()
        {
            var lastItem = this.data.LastOrDefault();

            if (lastItem == null)
            {
                throw new InvalidOperationException("The StackOfStrings is empty. Cannot pop any element!");
            }

            this.data.Remove(lastItem);
            return lastItem;
        }

        public string Peek()
        {
            var lastItem = this.data.LastOrDefault();

            if (lastItem == null)
            {
                throw new InvalidOperationException("The StackOfStrings is empty. Cannot pop any element!");
            }

            return lastItem;
        }

        public bool IsEmpty()
        {
            if (this.data.Any())
            {
                return false;
            }

            return true;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in this.data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}