namespace Blobs.Models.AttackTypes
{
    using System;

    using Contracts;

    public class Blobplode : IAttack
    {
        public int ChangeDamage(int oldDamage)
        {
            var newDamage = 2*oldDamage;

            return newDamage;
        }

        public int ChangeHealth(int oldHealth)
        {
            var newHealth = oldHealth - (int) Math.Floor((double) oldHealth/2);

            return newHealth;
        }
    }
}
