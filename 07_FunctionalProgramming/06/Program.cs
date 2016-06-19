using System;

namespace _06
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
            int exclude = int.Parse(Console.ReadLine());
            Predicate<int> exPredicate = x => x % exclude != 0;
            for (int i = ints.Length-1; i >= 0; i--)
            {
                if (exPredicate(ints[i]))
                    Console.Write(ints[i]+ " ");
            }
        }
    }
}
