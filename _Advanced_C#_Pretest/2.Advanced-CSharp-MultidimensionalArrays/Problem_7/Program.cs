using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();
            while (cmd != "search")
            {
                string[] peopleNumber = cmd.Split('-');
                if (!phonebook.ContainsKey(peopleNumber[0]))
                {
                    phonebook[peopleNumber[0]] = peopleNumber[1];
                }
                cmd = Console.ReadLine();
            
            }
            while (true)
            {
                cmd = Console.ReadLine();
                if(phonebook.ContainsKey(cmd))
                {
                    Console.WriteLine("{0} -> {1}", cmd, phonebook[cmd]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", cmd);
                }
            }
        }
    }
}
