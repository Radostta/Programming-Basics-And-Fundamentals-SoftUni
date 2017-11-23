using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(a => int.Parse(new string(a.Reverse().ToArray())))
                .Sum();

            Console.WriteLine(input);

            //We read, int. parse, but before that, we reverse each string, turn it into an array and sum its elements
        }
    }
}
