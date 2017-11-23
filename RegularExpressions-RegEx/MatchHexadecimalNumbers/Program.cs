using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b[0x]*[0-9A-F]+\b");
            //var regex = new Regex(@"\b(?:0x)?[0 - 9A - F]+\b");

            var input = Console.ReadLine();

            var numbersHex = regex.Matches(input).Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", numbersHex));


        }
    }
}
