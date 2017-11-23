using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
                var rounded = Math.Round(num, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine(rounded);
            }
            
        }
    }
}
