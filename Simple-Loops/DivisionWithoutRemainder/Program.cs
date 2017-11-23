using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    num2++;
                }
                if (num % 3 == 0)
                {
                    num3++;
                }
                if (num % 4 == 0)
                {
                    num4++;
                }                
            }

            double p2 = (num2 / n) * 100.0;
            double p3 = (num3 / n) * 100.0;
            double p4 = (num4 / n) * 100.0;

            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");

        }
    }
}
