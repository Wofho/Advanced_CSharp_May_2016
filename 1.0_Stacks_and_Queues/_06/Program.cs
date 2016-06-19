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
            int n = int.Parse(Console.ReadLine());
            Queue<int> gas = new Queue<int>();
            Queue<int> dist = new Queue<int>();
            Queue<int> diff = new Queue<int>();
            //int[] gas;
            for (int i = 0; i<n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                gas.Enqueue(int.Parse(line[0]));
                dist.Enqueue(int.Parse(line[1]));
            }

            for (int i = 0; i < n; i++)
            {
                int gass = gas.Peek();
                int distt = dist.Peek();



                diff.Enqueue(gass - distt);
                gas.Dequeue();
                dist.Dequeue();
            }
            int num = -4;
            int min = 1234;
            for (int i=0;i<diff.Count();i++)
            {
                
                int z = diff.Peek();
                Console.WriteLine(z);
                if (z > 0 && z < min)
                {

                        min = z;
                        num = i;



                }
                diff.Dequeue();
                
            }
            if(num<0 || min == 1234)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine(num);
            }





        }
    }
}
