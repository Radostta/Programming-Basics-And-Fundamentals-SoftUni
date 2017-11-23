using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumStep3_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 3 == 0) sum1 += number;
                if (i % 3 == 1) sum2 += number;
                if (i % 3 == 2) sum3 += number;
            }
            Console.WriteLine($"Sum1 = {sum1}");
            Console.WriteLine($"Sum2 == {sum2}");
            Console.WriteLine($"Sum3 == {sum3}");

        }
    }
}
