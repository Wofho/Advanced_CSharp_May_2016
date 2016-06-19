using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, SortedDictionary<string,int>> students = new Dictionary<string, SortedDictionary<string, int>>();
            while (!input.Contains("END"))
            {
                if (!students.ContainsKey(input[0]))
                {
                    students.Add(input[0], new SortedDictionary<string, int>());
                }
                if (!students[input[0]].ContainsKey(input[1]))
                {
                    students[input[0]][input[1]] = 0;
                }
                students[input[0][input[1]] = int.Parse(input[2]);
            }
            string first = String.Empty;
            
            foreach (var outerPair in students)
            {
                first = outerPair.Key;
                foreach (var innerPair in outerPair.Value)
                {
                    if(innerPair.Value==1)
                        Console.WriteLine("{0} {1}",first,innerPair.Key);
                }
                

            }



        }
    }
}
