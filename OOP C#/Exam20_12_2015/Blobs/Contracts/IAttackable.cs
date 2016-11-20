namespace Blobs.Contracts
{
    public interface IAttackable
    {
        void AttackEnemy(IBlob enemyBlob, IAttack attackType);
    }
}
