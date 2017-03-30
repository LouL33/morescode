using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        public static Dictionary<char, string> TwoList()
        {
            var rv = new Dictionary<char,string>();
            using (var codeBreaker = new StreamReader(path))
            {
                while(codeBreaker.Peek() > -1)
                {
                    var line = codeBreaker.ReadLine().Split(',');                   
                    rv.Add(char.Parse(line[0]),line[1]);
                }
            }
            return rv;
        }

        const string path = "morse.csv";
        static void SaveCode(Dictionary<char, string> userInPut)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var input in userInPut)
                {
                    writer.WriteLine(userInPut);
                }
            }
        }

        static void DisplayInPut(Dictionary<char,string>TwoList)
        {
            foreach(var userInPut in TwoList)
            {
                Console.WriteLine(userInPut);
            }
        }

        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();



            var userInPut = TwoList();
            Console.WriteLine("Thow shall giveth a letter");
            var input = Console.ReadLine();
            SaveCode(userInPut);
        }
         



    }
}
