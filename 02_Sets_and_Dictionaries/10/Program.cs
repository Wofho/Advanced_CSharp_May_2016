using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>(); 
            while(!input.Contains("report"))
            {
                if(!populationCounter.ContainsKey(input[1]))
                {
                    populationCounter.Add(input[1], new Dictionary<string, long>());
                }
                if(!populationCounter[input[1]].ContainsKey(input[0]))
                {
                    populationCounter[input[1]][input[0]] = 0;
                }
                populationCounter[input[1]][input[0]]+= int.Parse(input[2]);

                input = Console.ReadLine().Split('|');
            }
            string output="";

            foreach (var outerPair in populationCounter.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                long i = 0;
                string outputbackup = "";
                //Console.WriteLine("{0} (total population: {1})", outerPair.Key, outerPair.Key);
                foreach (var innerPair in outerPair.Value.OrderByDescending(key => key.Value))
                {
                    //Console.WriteLine("=>{0}: {1}", innerPair.Key, innerPair.Value);
                    i += innerPair.Value;
                    outputbackup += "=>" + innerPair.Key + ": " + innerPair.Value+ Environment.NewLine;

                }
                output += outerPair.Key + " (total population: " + i + ")"+ Environment.NewLine;
                output += outputbackup;
            }
            Console.WriteLine(output);
        }
    }
}


//.OrderBy(key => key.Value)