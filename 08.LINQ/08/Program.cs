using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
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
            studList.Where(x => x.Skip(2).Count(y=> int.Parse(y) <=3) >=2).ToList().ForEach(x=>Console.WriteLine(x[0]+ " "+ x[1]));

            
        }
    }
}
