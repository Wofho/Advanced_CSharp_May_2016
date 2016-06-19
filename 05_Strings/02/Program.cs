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
            string input = Console.ReadLine();
            for(int i =0;i<20;i++)
            {
                try
                {
                    Console.Write(input[i]);
                }
                catch
                {
                    Console.Write("*");
                }
            }
            
        }
    }
}
