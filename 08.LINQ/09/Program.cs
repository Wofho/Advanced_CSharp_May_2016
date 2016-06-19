using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string[]> studList = new List<string[]>();
            while (input != "END")
            {
                string[] studStrings = input.Split();
                studList.Add(studStrings);
                input = Console.ReadLine();
            }
            studList.Where(x => x[0].Substring(x[0].Length - 2) == "15" || x[0].Substring(x[0].Length - 2) == "14").ToList().ForEach(x => Console.WriteLine(string.Join(" ",x[1],x[2],x[3],x[4])));

        }
    }
}
