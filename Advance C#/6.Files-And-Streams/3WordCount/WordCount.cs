using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class WordCount
{
    static void Main()
    {
        string line;
        
        using (StreamReader readerWords = new StreamReader("..\\..\\words.txt"))
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] wordsTemp = readerWords.ReadToEnd().ToLower().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < wordsTemp.Length; i++)
			{
			    if (!words.ContainsKey(wordsTemp[i]))
                {
                    words.Add(wordsTemp[i],0);                   
                }
			}
            
            int[] wordsCount = new int[words.Count];
            using (StreamReader readerText = new StreamReader("..\\..\\text.txt"))
            {
                while ((line = readerText.ReadLine()) != null)
                {
                    string[] wordsInLine = line.ToLower().Split(new char[] { ' ', ',', '.', '!', '-', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < wordsInLine.Length; i++)
                    {
                        if (words.ContainsKey(wordsInLine[i]))
                        {
                            words[wordsInLine[i]]++;
                        }                        
                    }
                }
            }

            words = words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            using (StreamWriter writer = new StreamWriter("..\\..\\result.txt"))
            {
                foreach (var key in words.Keys)
                {
                    writer.WriteLine("{0} - {1}", key, words[key]);
                }
            }
        }        
    }
}

