using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            double[] doubleArr = Array.ConvertAll(numbers, Double.Parse);
            List<double> doubleList = new List<double>();
            List<int> intList = new List<int>();

            foreach (double x in doubleArr)
            {
                if(x % 1 == 0)
                {
                    intList.Add((int)x);
                }
                else
                {
                    doubleList.Add(x);
                }
            }

            double doubleMin = doubleList.Min();
            double doubleMax = doubleList.Max();
            double doubleSum = doubleList.Sum();
            double doubleAvg = doubleList.Average();

            int intMin = intList.Min();
            int intMax = intList.Max();
            int intSum = intList.Sum();
            double intAvg = intList.Average();

            Console.WriteLine("{0} -> min: {1:#.###}, max: {2:#.###}, sum: {3:#.###}, avg: {4:#.###}",0,
     doubleMin, doubleMax, doubleSum, doubleAvg);
            Console.WriteLine("{0} -> min: {1}, max: {2}, sum: {3}, avg: {4:#.###}",0,
                 intMin, intMax, intSum, intAvg);

        }
    }
}
