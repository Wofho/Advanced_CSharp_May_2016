using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> sd = new SortedDictionary<char, int>();
            
            for(int i = 0;i<input.Length;i++)
            {

                if(sd.ContainsKey(input[i]))
                {
                    sd[input[i]] += 1;
                }
                else
                {
                    sd.Add(input[i], 1);
                }
            }

            foreach(var kv in sd)
            {
                Console.WriteLine("{0}: {1} time/s", kv.Key, kv.Value);
            }
        }
    }
}
