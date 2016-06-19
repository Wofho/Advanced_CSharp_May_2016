using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> program =
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            string input = Console.ReadLine().Trim();

            while(input!="END")
            {
                string[] items = input.Split(';');
                if(!program.ContainsKey(items[0]))
                {
                    SortedDictionary<string, SortedSet<string>> cityProgram = new SortedDictionary<string, SortedSet<string>>();
                    program[items[0]] = cityProgram;
                }
                if (!program[items[0]].ContainsKey(items[1]))
                {
                    SortedSet<string> cityProgramSet = new SortedSet<string>();
                    program[items[0]][items[1]] = cityProgramSet;
                }
                program[items[0]][items[1]].Add(items[2]);
                input = Console.ReadLine().Trim();
            }

            foreach(string city in program.Keys)
            {
                Console.WriteLine(city);
                //SortedDictionary<string, SortedSet<string>> cityVenues = program[city];
                foreach(string venue in program[city].Keys)
                {
                    SortedSet<string> performers = program[city][venue];
                    string performersSTR = string.Join(", ",performers);
                    Console.WriteLine("->{0}: {1}",venue, performersSTR);
                }

            }



        }
    }
}
