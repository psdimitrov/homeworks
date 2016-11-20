namespace Blobs.Contracts
{
    public interface IAttack
    {
        int ChangeDamage(int oldDamage);
        int ChangeHealth(int oldHealth);
    }
}
