using System;

namespace _02
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Action<string> printz = message => Console.WriteLine("Sir {0}", message);
            foreach (var VARIABLE in input)
            {
                printz(VARIABLE);
            }
        }
    }
}
