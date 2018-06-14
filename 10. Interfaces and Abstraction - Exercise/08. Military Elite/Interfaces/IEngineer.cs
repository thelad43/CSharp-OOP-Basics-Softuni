namespace _08._Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyList<IRepair> Repairs { get; }
    }
}