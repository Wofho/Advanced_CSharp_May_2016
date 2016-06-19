using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long fromBase = long.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);


            string reversed = Reverse(input[1]);

            BigInteger result = 0;
            for(int i = 0;i<reversed.Length;i++)
            {
                result += BigInteger.Parse(reversed.Substring(i,1))* ((BigInteger)Math.Pow(fromBase,i));

            }
            Console.WriteLine(result);

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
