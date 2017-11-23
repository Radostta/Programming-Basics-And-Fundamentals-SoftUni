using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6AdvancedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = int.Parse(Console.ReadLine());
            int combinations = 0;
            string current = "";

            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 <= 9; d2++)
                {
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            if (((d1 * d2) + (d3 * d4) == control) && (d1 < d2) && (d3 > d4))
                            {
                                Console.Write($"{d1}{d2}{d3}{d4} ");
                                combinations++;
                                if (combinations == 4)
                                {
                                    current = ($"{d1}{d2}{d3}{d4} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
           
            if (combinations < 4)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine($"Password: {current}");

            }

        }
    }
}
