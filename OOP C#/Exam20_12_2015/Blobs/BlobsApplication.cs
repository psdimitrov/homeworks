namespace Blobs
{
    using Core;
    using IO;
    
    public class BlobsApplication
    {
        static void Main(string[] args)
        {
            var blobFactory = new BlobFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new BlobsData();
            var engine = new Engine(blobFactory, data, reader, writer);
            engine.Run();
        }
    }
}
