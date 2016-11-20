namespace Blobs.Contracts
{
    public interface IBlobFactory
    {
        IBlob CreateBlob(string name, int health, int damage, string behavior, string attackType);
    }
}
