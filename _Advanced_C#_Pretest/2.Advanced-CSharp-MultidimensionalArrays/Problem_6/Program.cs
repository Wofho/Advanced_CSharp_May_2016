using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
    static void Main()
    {
        string str = Console.ReadLine();

        var letters = new SortedDictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (letters.ContainsKey(str[i]))
            {
                letters[str[i]] = letters[str[i]] + 1;
            }
            else
            {
                letters[str[i]] = 1;
            }
        }
        foreach (var item in letters)
        {
            Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
        }
    }
}