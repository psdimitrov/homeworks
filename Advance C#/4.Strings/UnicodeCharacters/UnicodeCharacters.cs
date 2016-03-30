using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();
        
        Console.WriteLine(GetUnicode(text));   
           
    }
    static string GetUnicode(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            sb.Append(string.Format("\\u{0:x4}", (ushort)str[i]));
        }
        return sb.ToString();
    }
}

