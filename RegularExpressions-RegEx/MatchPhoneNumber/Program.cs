using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"[\+359)]{4}( |-)[2]\1[0-9]{3}\1[0-9]{4}\b");

            var phones = Console.ReadLine();

            //Regex.Matches(phones, regex);

            //MatchCollection to Matches with their values only, trimmed, to an Array:
            var phoneMatches = regex.Matches(phones).Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            //Print the array of matches:
            Console.WriteLine(string.Join(", ", phoneMatches));
            
        }
    }
}
