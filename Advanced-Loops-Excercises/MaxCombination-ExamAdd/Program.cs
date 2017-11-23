using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int first = start; first <= finish; first++)
            {
                for (int second = start; second <= finish; second++)
                {
                    if (combinations >= maxCombinations) break;
                    Console.Write($"<{first}-{second}>");
                    combinations += 1;
                }
            }
            Console.WriteLine();
        }
    }
}
