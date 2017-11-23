using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers_Exam
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());

            for (int f = 0; f <= 9; f++)
            {
                for (int s = 0; s <= 9; s++)
                {
                    for (int t = 0; t <= 9; t++)
                    {
                        for (int ft = 0; ft <= 9; ft++)
                        {
                            for (int ff = 0; ff <= 9; ff++)
                            {
                                for (int sx = 0; sx <= 9; sx++)
                                {
                                    if (f * s * t * ft * ff * sx == n) Console.Write($"{f}{s}{t}{ft}{ff}{sx} ");
                                }
                            }
                        }
                    }
                }
            } 
            Console.WriteLine();
           

        }
    }
}
