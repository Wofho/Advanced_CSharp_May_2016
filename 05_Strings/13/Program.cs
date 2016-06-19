using System;
using System.Collections.Generic;

namespace _13
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            char[] inp1 = input[0].ToCharArray();
            char[] inp2 = input[1].ToCharArray();
            var hs1 = new HashSet<char>(inp1);
            var hs2 = new HashSet<char>(inp2);
            Console.WriteLine(hs1.Count == hs2.Count ? "true" : "false");
        }
    }
}
