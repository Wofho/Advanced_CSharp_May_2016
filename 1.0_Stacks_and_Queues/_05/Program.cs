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

            int n = int.Parse(Console.ReadLine());
            int j = 0;
            int m = 0;
            Queue<int> que = new Queue<int>();
            que.Enqueue(n);
            m = que.Peek();
            Console.WriteLine();
            for (int i = 1; i<50;i++)
            {              
                que.Enqueue(m+1);
                que.Enqueue(2*m+1);
                que.Enqueue(m + 2);
                m += i;

            }

            int[] myStandardArray = que.ToArray();
            foreach(var elem in myStandardArray)
            {
                if(j<50)
                {
                    Console.WriteLine(elem);
                    j++;
                }
            }
        }
    }
}
