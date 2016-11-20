namespace Blobs.Contracts
{
    public interface IBlob : IAttacker, IDestroyable, IAttackable, IUpdateable
    {
        string Name { get; }
        bool Dead { get; }
    }
}
