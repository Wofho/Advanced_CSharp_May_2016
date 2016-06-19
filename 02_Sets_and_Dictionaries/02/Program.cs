using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = Console.ReadLine().Split();
            HashSet<int> hs1 = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();

            for (int i = 0; i < int.Parse(cmd[0]); i++)
            {
                hs1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < int.Parse(cmd[1]); i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());
                hs2.Add(numberToAdd);
                if (hs1.Contains(numberToAdd))
                {
                    Console.WriteLine(numberToAdd);
                }
            }


        }
    }
}
