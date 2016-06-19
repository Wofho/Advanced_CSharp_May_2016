using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgx = new Regex(@"^[A-Z][a-z]+ [A-Z]{1}[a-z]+$");

            while (input!="end")
            {
                if(rgx.IsMatch(input))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
