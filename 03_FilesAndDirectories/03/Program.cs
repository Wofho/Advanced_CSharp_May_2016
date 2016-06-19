using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "words.txt")).Split();
            string[] input = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "text.txt")).Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordsInText = new Dictionary<string, int>();

            foreach(var word in words)
            {
                if(input.Contains(word))
                {
                    var matchQuery = from wordz in input
                                         //where wordz.ToLowerInvariant() == word.ToLowerInvariant()
                                     where String.Equals(wordz, word, StringComparison.OrdinalIgnoreCase)
                                     select wordz;
                    if (!wordsInText.ContainsKey(word))
                    {
                        wordsInText.Add(word, matchQuery.Count());

                    }
                    else
                    {
                        wordsInText[word]+= matchQuery.Count();
                    }
                }
            }
            string[] linesToWrite = new string[wordsInText.Count()];
            int i = 0;
            foreach (var kv in wordsInText)
            {
                linesToWrite[i] = kv.Key + " - " + kv.Value;
                i++; 
            }

            File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, "output.txt"), linesToWrite);
        }
    }
}
