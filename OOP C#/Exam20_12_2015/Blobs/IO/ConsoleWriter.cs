namespace Blobs.IO
{
    using System;

    using Contracts;

    public class ConsoleWriter : IOutputWriter
    {
        public void PrintLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
