using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            var input = Console.ReadLine();

            var numbers = regex.Matches(input);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
