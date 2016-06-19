using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] result = Array.ConvertAll(numbers.Split(' '), Convert.ToInt32);
            Array.Sort(result);
            foreach (int number in result)
            {
                Console.Write(number+" ");
            }

        }
    }
}
