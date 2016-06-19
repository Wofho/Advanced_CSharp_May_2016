using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string[] result = strings.Distinct().ToArray();
            Dictionary<string, int> foo = new Dictionary<string, int>();
            foreach (string c in strings)
            {
                if (!foo.ContainsKey(c))
                {
                    foo.Add(c, 1);
                }
                else
                {
                    foo[c] += 1;
                }
            }
            foreach (var c in foo)
            {
                if(c.Value==1)
                {
                    Console.WriteLine(c.Key);
                }
                else
                {
                    for(int i = 0;i<c.Value-1;i++)
                    {
                        Console.Write(c.Key + ' ');
                    }
                    Console.Write(c.Key);
                    Console.WriteLine();
                }
            }
        }
    }
}
