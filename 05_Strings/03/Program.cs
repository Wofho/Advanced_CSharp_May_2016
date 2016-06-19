using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitter = new char[] { ' ', '\t', '\n' };
            string[] input = Console.ReadLine().Split(splitter,StringSplitOptions.RemoveEmptyEntries);
            int first = int.Parse(input[0]);
            double second = double.Parse(input[1]);
            double third = double.Parse(input[2]);

            //StringBuilder sb = new StringBuilder();
            //string hexValue = first.ToString("X");
            //string binary = Convert.ToString(first, 2);
            //string[] second2 = second.ToString().Split('.');
            //string[] third3 = third.ToString().Split('.');

            //sb.Append("|");
            //sb.Append(hexValue.PadRight(10));
            //sb.Append("|");
            //sb.Append(binary.PadLeft(10, '0').Substring(0, 10));
            //sb.Append("|");
            //sb.Append(string.Format("{0:F2}", second).PadLeft(10));
            //sb.Append("|");
            //sb.Append(string.Format("{0:F3}", third).PadRight(10));
            //sb.Append("|");

            //Console.WriteLine(sb.ToString());
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|",
                first,
                Convert.ToString(first, 2).PadLeft(10, '0'),
                second,
                third);


        }
    }
}
