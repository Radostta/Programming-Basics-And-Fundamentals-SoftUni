using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int d1 = 1; d1 <= 4; d1++)
            {
                for (int d2 = 1; d2 <= 4; d2++)
                {
                    for (int d3 = 1; d3 <= 4; d3++)
                    {
                        count++;

                        if ((d1 + d2 + d3) >= matchSum)
                        {
                            Console.Write("O" + ("" + d1 + d2 + d3).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + d1 + d2 + d3).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }

                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
