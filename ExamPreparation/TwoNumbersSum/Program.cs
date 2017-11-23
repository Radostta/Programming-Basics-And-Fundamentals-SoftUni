using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int combinationsCount = 0;
            bool combinationFound = false;

            for (int n1 = start; n1 >= finish; n1--)
            {
                for (int n2 = start; n2 >= finish; n2--)
                {
                    combinationsCount++;

                    if (n1 + n2 == magic)
                    {
                        int currentCombination = combinationsCount;
                        combinationFound = true;
                        Console.WriteLine($"Combination N:{currentCombination} ({n1} + {n2} = {magic})");
                        break;
                    }
                }
                if (combinationFound == true) break;
            }

            if (combinationFound == false)
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magic}");
            }
        }
    }
}
