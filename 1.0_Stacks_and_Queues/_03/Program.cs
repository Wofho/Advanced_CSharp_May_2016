//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _03
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            Stack<int> staq = new Stack<int>();
//            string result= "";
//            for(int i = 0; i < n; i++)
//            {
//                string input = Console.ReadLine();
//                if(input.Contains("1 "))
//                {
//                    string[] inp = input.Split(' ');
//                    int[] number = Array.ConvertAll(inp, int.Parse);
//                    staq.Push(number[1]);
//                }
//                else if(input=="2")
//                {
//                    staq.Pop();
//                }
//                else if(input=="3")
//                {
//                    result+=staq.Max()+Environment.NewLine;
//                }
//            }
//            Console.WriteLine(result);
//        }
//    }
//}


using System;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N, val, currMax, pointer = 0;
        char query;
        N = Convert.ToInt32(Console.ReadLine());
        int[] stack = new int[N];
        for (int i = 0; i < N; ++i)
        {
            string line = Console.ReadLine();
            query = line[0];
            if (query == '1')
            {
                val = Convert.ToInt32(line.Substring(2));
                if (pointer == 0)
                {
                    stack[pointer++] = val;
                }
                else
                {
                    currMax = stack[pointer - 1];
                    stack[pointer++] = (val > currMax) ? val : currMax;
                }
            }
            else if (query == '2')
            {
                --pointer;
            }
            else
            {
                Console.WriteLine(stack[pointer - 1]);
            }
        }
    }
}