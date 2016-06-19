using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> hs = new HashSet<string>();
            for(int i = 0;i<n;i++)
            {
                hs.Add(Console.ReadLine());

            }

            foreach(string result in hs)
            {
                Console.WriteLine(result);
            }
        }
    }
}
