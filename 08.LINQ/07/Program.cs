using System;
using System.Collections.Generic;
using System.Linq;

namespace _07
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> studList = new List<string>();
            while (input != "END")
            {
                studList.Add(input);
                input = Console.ReadLine();
            }
            foreach (var stud in studList.Where(x=>x.Contains("6")).Select(x=>x.Split()))
            {
                Console.WriteLine(stud[0]+ " " + stud[1]);
            }
        }
    }
}
