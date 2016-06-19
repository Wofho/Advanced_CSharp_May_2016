using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger toBase = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            string parsedNumber = string.Empty;
            while(number >0 )
            {
                parsedNumber += number % toBase;
                number /= toBase;
            }
            char[] toBeReversed = parsedNumber.ToCharArray();
            Array.Reverse(toBeReversed);

            Console.WriteLine(toBeReversed);

        }
    }
}
