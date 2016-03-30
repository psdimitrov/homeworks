using System;
using System.IO;


class Program
{
    const string Source = @"..\..\something.jpg"; 
    const string Destination = @"..\..\copy.jpg";
    static void Main()
    {
        FileStream readingStream = new FileStream(Source, FileMode.Open);
        FileStream writingStream = new FileStream(Destination, FileMode.Create);
        byte[] buffer = new byte[4096];
        using(readingStream)
        {
            using(writingStream)
            {
                while (readingStream.Read(buffer, 0, 4096) !=0)
                {                    
                    writingStream.Write(buffer,0,buffer.Length);
                }
            }
        }
    }
}
