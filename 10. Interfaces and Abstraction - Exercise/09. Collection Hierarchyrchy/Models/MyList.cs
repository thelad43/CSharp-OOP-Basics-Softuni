namespace _09._Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Linq;

    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        private const int RemoveIndex = 0;

        public int Count => this.Data.Count;

        public override T Remove()
        {
            var firstElemennt = this.Data.FirstOrDefault();
            this.Data.RemoveAt(RemoveIndex);
            return firstElemennt;
        }
    }
}