using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
        Console.WriteLine("Enter the contact detail in the form:\nName-Number");
        string input = Console.ReadLine();
        string[] entries;
        string name;
        string number;
        while (input != "search")
        {
            entries = input.Split('-');
            name = entries[0];
            number = entries[1];
            if(!phonebook.ContainsKey(name))
            {
                phonebook[name] = new List<string>();                
            }
            phonebook[name].Add(number);
            input = Console.ReadLine();
        }
        input = Console.ReadLine();
        while (!string.IsNullOrEmpty(input))
        {
            if (phonebook.ContainsKey(input))
            {
                Console.WriteLine("{0} -> {1}", input, string.Join(", ",phonebook[input]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", input);
            }
            input = Console.ReadLine();
        }
    }
}

