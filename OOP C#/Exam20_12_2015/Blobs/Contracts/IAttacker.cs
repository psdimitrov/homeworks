namespace Blobs.Contracts
{
    public interface IAttacker
    {
        int Damage { get; set; }
        IAttack Attack { get; }
    }
}
