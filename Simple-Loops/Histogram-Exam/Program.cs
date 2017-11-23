using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num1To199 = 0.0;
            var num200To399 = 0.0;
            var num400To599 = 0.0;
            var num600To799 = 0.0;
            var num800To1000 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num >= 1 && num <= 199)
                {
                    num1To199 += 1;
                }
                else if (num >= 200 && num <= 399)
                {
                    num200To399 += 1;
                }
                else if (num >= 400 && num <= 599)
                {
                    num400To599 += 1;
                }
                else if (num >= 600 && num <= 799)
                {
                    num600To799 += 1;
                }
                else if (num >= 800 && num <= 1000)
                {
                    num800To1000 += 1;
                }
            }

            var perc1To199 = num1To199 / n * 100.0;
            var perc200To399 = num200To399 / n * 100.0;
            var perc400To599 = num400To599 / n * 100.0; ;
            var perc600To799 = num600To799 / n * 100.0;
            var perc800To1000 = num800To1000 / n * 100.0;

            Console.WriteLine($"{perc1To199:f2}%");
            Console.WriteLine($"{perc200To399:f2}%");
            Console.WriteLine($"{perc400To599:f2}%");
            Console.WriteLine($"{perc600To799:f2}%");
            Console.WriteLine($"{perc800To1000:f2}%");


        }
    }
}
