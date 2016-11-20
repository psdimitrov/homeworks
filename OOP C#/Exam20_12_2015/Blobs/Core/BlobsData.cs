namespace Blobs.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;

    public class BlobsData : IBlobsData
    {
        private readonly ICollection<IBlob> blobs = new LinkedList<IBlob>();

        public void AddBlob(IBlob blob)
        {
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            if (blobs.Any(blob1 => blob1.Name == blob.Name))
            {
                throw new InvalidOperationException("Blob with this name already exists!");
            }

            this.blobs.Add(blob);

        }
        public IEnumerable<IBlob> Blobs => this.blobs;
    }
}
