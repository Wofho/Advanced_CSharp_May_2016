using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));
            string[] linesToWrite = new string[lines.Count()];
            int i = 0;
            foreach(var line in lines)
            {
                i++;
                string output = i+ ". " + line;
                linesToWrite[i - 1] = output;
            }

            File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, "output.txt"), linesToWrite);
        }
    }
}
