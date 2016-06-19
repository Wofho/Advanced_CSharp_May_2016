using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            string numbers = Console.ReadLine();
            int[] result = Array.ConvertAll(numbers.Split(), Convert.ToInt32);
            Stack<int> staq = new Stack<int>();
            for(int i = 0;i< result.Length ;i++)
            {
                staq.Push(result[i]);
            }
            for (int i = 0; i < staq.Count(); i++)
            {
                int pop =  staq.Pop();
                Console.Write(pop+" ");
            }

        }
    }
}
