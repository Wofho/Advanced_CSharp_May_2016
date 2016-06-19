using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        var letters = new SortedDictionary<char, int>();
        for(int i = 0; i<str.Length;i++)
        {
            if(!letters.ContainsKey(str[i]))
            {
                letters[str[i]] = 1;
            }
            else
            {
                letters[str[i]] += 1;
            }
        }
        foreach(var key in letters)
        {
            Console.WriteLine("{0}: {1} time/s", key.Key, key.Value);
        }
    }
}