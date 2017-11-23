using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var input = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();

            var regex = new Regex(@"\b" + word + @"\b");

            foreach (var sentence in input)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
