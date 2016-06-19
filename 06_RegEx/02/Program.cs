using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgx = new Regex(@"^\+359-\d{1}-\d{3}-\d{4}$");
            Regex rgx2 = new Regex(@"^\+359\s\d{1}\s\d{3}\s\d{4}$");
            while (input != "end")
            {
                if (rgx.IsMatch(input)||rgx2.IsMatch(input))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
