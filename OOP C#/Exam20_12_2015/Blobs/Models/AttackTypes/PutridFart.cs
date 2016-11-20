namespace Blobs.Models.AttackTypes
{
    using Blobs.Contracts;

    public class PutridFart : IAttack
    {
        public int ChangeDamage(int oldDamage)
        {
            return oldDamage;
        }

        public int ChangeHealth(int oldHealth)
        {
            return oldHealth;
        }
    }
}
