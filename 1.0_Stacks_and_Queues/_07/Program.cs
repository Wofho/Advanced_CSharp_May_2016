using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
            string[] results = Array.ConvertAll(result.Split(), Convert.ToString);
            for (int i = 0; i< result.Count()/2;i++)
            {
                if(results[i] != results[result.Count()-1-i])
                {
                    Console.WriteLine("NO");
                }
            }


        }
    }
}
