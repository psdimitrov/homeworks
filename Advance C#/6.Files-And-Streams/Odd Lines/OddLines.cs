using System;
using System.IO;



class OddLines
{
    const string InputFile = @"..\..\Students-data.txt";
    static void Main()
    {
        StreamReader streamreader = new StreamReader(InputFile);
        bool isOdd = true;
        try
        {                
            string line;
            while ((line = streamreader.ReadLine()) != null)
            {
                if (isOdd)
                {
                    Console.WriteLine(line);
                    isOdd = false;
                }
                else
                {
                    isOdd = true;
                }
            }
        }
        finally
        {
            streamreader.Close();
        }
    }
}
