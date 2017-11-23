using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split()
                .Select(a => a.ToCharArray().Distinct().ToArray())
                .ToArray();

            var firstLength = strings.First().Length;

            Console.WriteLine(strings.All(a => a.Length == firstLength).ToString().ToLower());
        }
    }
}
