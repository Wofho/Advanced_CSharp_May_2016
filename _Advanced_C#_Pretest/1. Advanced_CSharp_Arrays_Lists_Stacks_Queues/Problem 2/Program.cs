using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] result = Array.ConvertAll(numbers.Split(' '), Convert.ToInt32);
            //Array.Sort(result);
            for(int i = 0; i<result.Length-1; i++)
            {
                int min_pos=i, temp;
                for(int j = i+1; j< result.Length; j++)
                {
                    if(result[j]<result[min_pos])
                    {
                        min_pos = j;
                    }
                }

                if(min_pos!=i)
                {
                    temp = result[i];
                    result[i] = result[min_pos];
                    result[min_pos] = temp;
                }
            }

            foreach (int number in result)
            {
                Console.Write(number + " ");
            }

        }
    }
}