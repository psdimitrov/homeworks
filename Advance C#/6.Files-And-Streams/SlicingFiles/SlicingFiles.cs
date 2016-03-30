using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class SlicingFiles
{
    const string Source = @"..\..\arrays.mp4";
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
            
            for (int i = 0; i < parts -1; i++)
            {
                using (FileStream writingStream = new FileStream(destinationDirectory + "\\Part-" + i + fileExtension, FileMode.Create))
                {
                    for (int j = 0; j < size; j++)
                    {
                        readBytes = readingStream.Read(buffer, 0, buffer.Length);
                        writingStream.Write(buffer, 0, readBytes);

                    }
                }
            }
            using (FileStream writingStream = new FileStream(destinationDirectory + "\\Part-" + (parts - 1) + fileExtension, FileMode.Create))
            {
                while ((readBytes = readingStream.Read(buffer, 0, buffer.Length)) != 0)
                {                       
                    writingStream.Write(buffer, 0, readBytes);
                }
            }
        }                
    }
    static void Assemble(List<string> files,string destinationDirectory)
    {
        byte[] buffer = new byte[4096];
        int readBytes;
        string fileExtension = files[0].Substring(files[0].Length-4);
        using (FileStream writingStream = new FileStream(destinationDirectory + "\\assembled" + fileExtension, FileMode.Create))
        {
            foreach (var file in files)
            {
                using (FileStream readingStream = new FileStream(file,FileMode.Open))
                {
                    while ((readBytes = readingStream.Read(buffer,0,buffer.Length)) != 0)
                    {
                        writingStream.Write(buffer, 0, readBytes);
                    }
                }
            }
        }

    }
}
