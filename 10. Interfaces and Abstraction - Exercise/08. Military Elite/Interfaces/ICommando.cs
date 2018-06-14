namespace _08._Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyList<IMission> Missions { get; }
    }
}