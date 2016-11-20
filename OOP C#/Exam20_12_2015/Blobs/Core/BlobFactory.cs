namespace Blobs.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    using Models;    

    public class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, string behavior, string attackType)
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == attackType);

            if (type == null)
            {
                throw new ArgumentException("Unknown attack type.");
            }

            var attack = (IAttack) Activator.CreateInstance(type);

            var blob = new Blob(name, health, damage, attack, behavior);

            return blob;
        }
    }
}
