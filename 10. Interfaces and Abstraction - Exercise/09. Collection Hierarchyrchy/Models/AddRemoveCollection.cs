namespace _09._Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Linq;

    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        private const int IndexOfFirstElement = 0;

        public override int Add(T item)
        {
            this.Data.Insert(IndexOfFirstElement, item);
            return IndexOfFirstElement;
        }

        public virtual T Remove()
        {
            var lastElement = this.Data.LastOrDefault();
            this.Data.Remove(lastElement);
            return lastElement;
        }
    }
}