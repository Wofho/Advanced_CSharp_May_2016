using System;
using System.Linq;

namespace PP_Test
{
    class Program
    {
        static void Main()
        {
            int[] arr =
                // ReSharper disable once PossibleNullReferenceException
                Console.ReadLine().Split().Select(int.Parse).Distinct().Where(n => n%2 == 0).OrderBy(n => n).ToArray();
            foreach (var variable in arr)
            {
                Console.WriteLine(variable);
            }
        }
    }
}
