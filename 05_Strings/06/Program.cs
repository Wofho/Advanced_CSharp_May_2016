using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int occurrence = 0;
            int indexOf = 0;

            indexOf = input.IndexOf(pattern);
            while(indexOf!=-1)
            {
                occurrence++;
                indexOf = input.IndexOf(pattern, indexOf + 1);

            }
            Console.WriteLine(occurrence);
        }
    }
}
