namespace _09._Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddCollection<T> : IAddCollection<T>
    {
        protected List<T> Data { get; set; } = new List<T>();

        public virtual int Add(T item)
        {
            this.Data.Add(item);
            return this.Data.Count - 1;
        }
    }
}