using System;
using System.Collections.Generic;

class Dict
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        Console.WriteLine("What do you want to llok up?");
        string word = Console.ReadLine();

        bool found = false;
        foreach (var item in dictionary)
        {
            if (item.Key.ToLower() == word.ToLower())
            {
                found = true;
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }

        if (!found)
        {
            Console.WriteLine("The word's definition isn't in this dictionary.");
        }
    }
}

