using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        string directory = Console.ReadLine();
        DirectoryInfo dir= new DirectoryInfo(directory);
        FileInfo[] files = dir.GetFiles();
        Dictionary<string, int> extensions = new Dictionary<string, int>();
        foreach (var file in files)
        {
            if (extensions.ContainsKey(file.Extension))
            {
                extensions[file.Extension]++;
            }
            else
            {
                extensions.Add(file.Extension, 1);
            }
        }
        extensions = extensions.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        foreach (var item in extensions.Keys)
        {
            Console.WriteLine(item);
            foreach (var file in files.Where(x=>x.Extension==item).OrderBy(x => x.Length))
            {
                Console.WriteLine("--{0} - {1:F3}kb",file.Name,(double)file.Length/1024);
            }
        }
        
    }
}

