using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "input.txt");

            for(int i = 1;i<=File.ReadLines(path).Count(); i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(File.ReadLines(path).Skip(i-1).Take(1).First());
                }
            }
        }
    }
}
