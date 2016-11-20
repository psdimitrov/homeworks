namespace Blobs.Contracts
{
    using System.Collections.Generic;

    public interface IBlobsData
    {
        IEnumerable<IBlob> Blobs { get; }
        void AddBlob(IBlob blob);
    }
}
