namespace _09._Collection_Hierarchy.Interfaces
{
    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        int Count { get; }
    }
}