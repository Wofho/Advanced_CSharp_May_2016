using System;

namespace _01
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Action<string> print = message => Console.WriteLine(message);
            foreach (var VARIABLE in input)
            {
                print(VARIABLE);
            }

        }
    }
}
