namespace Blobs.Models.Behaviors
{
    using Contracts;

    public class Inflated : IBehavior
    {
        public Inflated(IBlob blob)
        {
            blob.Health += 50;
        }
        public void Behave(IBlob blob)
        {
            blob.Health -= 10;
        }
    }
}
