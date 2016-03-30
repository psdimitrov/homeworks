using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstrings
{
    static void Main()
    {
        string text = Console.ReadLine();
        string searchStr = Console.ReadLine();
        int count = 0;
        int index=0;

        index = text.IndexOf(searchStr, StringComparison.CurrentCultureIgnoreCase);
        while(index !=-1)
        {
            count++;
            index = text.IndexOf(searchStr, index+1, StringComparison.CurrentCultureIgnoreCase);            
        }

        Console.WriteLine(count);
    }
}

