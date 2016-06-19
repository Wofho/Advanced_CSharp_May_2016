using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> hs = new SortedSet <string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                foreach(string z in inputs)
                {
                    hs.Add(z);
                }
                
            }

            foreach(string el in hs)
            {
                Console.Write(el+' ');
            }
        }
    }
}
