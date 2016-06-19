using System;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] ints = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                ints[i] = int.Parse(input[i]);
            }
            Func<int[], int> inputFunc = intz => intz.Min();
            Console.WriteLine(inputFunc(ints));


        }

    }
}
