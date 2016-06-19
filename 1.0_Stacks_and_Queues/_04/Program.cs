using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string ints = Console.ReadLine();
            int[] intss = Array.ConvertAll(ints.Split(' '), Convert.ToInt32);
            int n = intss[0];
            int s = intss[1];
            int x = intss[2];


            string numbers = Console.ReadLine();
            int[] result = Array.ConvertAll(numbers.Split(' '), Convert.ToInt32);

            Queue<int> que = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                que.Enqueue(result[i]);
            }
            for (int i = 0; i < s; i++)
            {
                que.Dequeue();
            }
            if (que.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (que.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(que.Min());
            }
        }
    }
}
