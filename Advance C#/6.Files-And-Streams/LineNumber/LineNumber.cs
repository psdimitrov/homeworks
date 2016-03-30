using System;
using System.IO;

class LineNumber
{
    const string InputFile = @"..\..\source.sub";
    const string OutputFile = @"..\..\output.txt";

    static void Main()
    {
        StreamReader streamreader = new StreamReader(InputFile);
        StreamWriter streamwriter = new StreamWriter(OutputFile);
        try
        {
            string line;
            int lineNumber = 0;
            while((line = streamreader.ReadLine()) != null)
            {
                lineNumber++;
                streamwriter.WriteLine("{0}.{1}", lineNumber, line);
            }

        }
        finally
        {
            streamreader.Close();
            streamwriter.Close();
        }
        
    }
}
