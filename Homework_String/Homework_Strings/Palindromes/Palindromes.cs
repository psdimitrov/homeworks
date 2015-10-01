using System;
using System.Collections.Generic;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> palindromes = new SortedSet<string>();
        string reverse;

        for (int i = 0; i < words.Length; i++)
        {           
            reverse = string.Join("",words[i].Reverse().ToArray());
            if (words[i] == reverse)
            {          
                palindromes.Add(words[i]);
            }            
        }
        Console.WriteLine(string.Join(", ", palindromes));
    }
}
