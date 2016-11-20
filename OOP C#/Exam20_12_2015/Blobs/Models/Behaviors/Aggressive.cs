namespace Blobs.Models.Behaviors
{
    using Contracts;

    public class Aggressive : IBehavior
    {
        private readonly int initialDamage;

        public Aggressive(IBlob blob)
        {
            initialDamage = blob.Damage;
            blob.Damage *= 2;
        }

        public void Behave(IBlob blob)
        {
            if (blob.Damage - 5 >= this.initialDamage)
            {
                blob.Damage -= 5;
            }
        }
    }
}
