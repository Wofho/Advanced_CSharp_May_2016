using System;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] ints = Enumerable.Range(int.Parse(input[0]), int.Parse(input[1])- int.Parse(input[0]) + 1).ToArray();
            string caseOfResult = Console.ReadLine();
            Predicate<int> casePredicate = null;
            if (caseOfResult == "even")
            {
                casePredicate = x => x % 2 ==0;
            }
            else if (caseOfResult == "odd")
            {
                casePredicate = x => x % 2 != 0;
            }
            foreach (var variable in ints)
            {
                if(casePredicate(variable)==true)
                    Console.Write(variable+" ");
            }
        }
    }
}
