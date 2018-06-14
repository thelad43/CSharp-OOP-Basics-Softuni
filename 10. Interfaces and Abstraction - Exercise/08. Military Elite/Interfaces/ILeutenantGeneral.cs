namespace _08._Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral : IPrivate
    {
        IReadOnlyList<IPrivate> PrivateSoldiers { get; }
    }
}