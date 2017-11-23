using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var lastPair = 0;
            var maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());

                var currentPair = num1 + num2;

                if (i > 0)
                {
                    if (currentPair != lastPair)
                    {
                        maxDiff = Math.Abs(currentPair - lastPair);
                    }                    
                }

                lastPair = currentPair;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={lastPair}.");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");

            }
           
        }
    }
}
