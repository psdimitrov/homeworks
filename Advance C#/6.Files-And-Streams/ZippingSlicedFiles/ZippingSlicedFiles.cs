using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;


class ZippingSlicedFiles
{
    const string Source = @"..\..\SoftUni-Learning plan.mp4";
    const string Destination = @"..\..\directory";
    static void Main()
    {
        Console.Write("parts = ");
        int parts = int.Parse(Console.ReadLine());
        Directory.CreateDirectory(Destination);
        Slice(Source, Destination, parts);
        var files = Directory.GetFiles(Destination);
        Assemble(files.ToList(), Destination);
    }
    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        byte[] buffer = new byte[4096];
        using (FileStream readingStream = new FileStream(sourceFile, FileMode.Open))
        {
            long size = readingStream.Length / 4096;
            size = size / parts;
            int readBytes;
            string fileExtension = readingStream.Name.Substring(readingStream.Name.Length - 4);

            for (int i = 0; i < parts - 1; i++)
            {
                using (FileStream writingStream = new FileStream(destinationDirectory + "\\Part-" + i + ".gz", FileMode.Create))
                {
                    using (GZipStream gz = new GZipStream(writingStream, CompressionMode.Compress, false))
                    {
                        for (int j = 0; j < size; j++)
                        {
                            readBytes = readingStream.Read(buffer, 0, buffer.Length);
                            gz.Write(buffer, 0, readBytes);

                        }
                    }
                }
            }
            using (FileStream writingStream = new FileStream(destinationDirectory + "\\Part-" + (parts - 1) + ".gz", FileMode.Create))
            {
                using (GZipStream gz = new GZipStream(writingStream, CompressionMode.Compress, false))
                {
                    while ((readBytes = readingStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        gz.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
    static void Assemble(List<string> files, string destinationDirectory)
    {
        byte[] buffer = new byte[4096];
        int readBytes;
        string fileExtension = Source.Substring(Source.Length - 4);
        using (FileStream writingStream = new FileStream(destinationDirectory + "\\assembled" + fileExtension, FileMode.Create))
        {            
            foreach (var file in files)
            {
                using (FileStream readingStream = new FileStream(file, FileMode.Open))
                {
                    using (GZipStream decompressionStream = new GZipStream(readingStream, CompressionMode.Decompress, false))
                    {
                        while ((readBytes = decompressionStream.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            writingStream.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

    }
}
