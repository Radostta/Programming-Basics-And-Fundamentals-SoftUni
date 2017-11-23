using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_AllNumberCombinations_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endCycles = false;

            for (int i = 1; i <= 3; i++)
            {
                if (endCycles == false)
                {
                    for (int j = 3; j >= 1; j--)
                    {
                        if (i + j == 2)
                        {
                            endCycles = true;
                            break;
                        }
                        Console.WriteLine($"{i} {j}");
                    }
                }
            }

        }
    }
}
