using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] ints = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                ints[i] = int.Parse(input[i]);
            }
            string caseString = Console.ReadLine();
            string result = string.Empty;
            while (caseString!="end")
            {
                switch (caseString)
                {
                    case "add":
                        for (int i = 0; i < ints.Length; i++)
                        {
                            ints[i]++;
                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < ints.Length; i++)
                        {
                            ints[i] *= 2;
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < ints.Length; i++)
                        {
                            ints[i]--;
                        }
                        break;
                    case "print":
                        for (int i = 0; i < ints.Length; i++)
                        {
                            result += ints[i]+" ";
                        }
                        result += "\n";
                        break;
                }
                caseString = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
