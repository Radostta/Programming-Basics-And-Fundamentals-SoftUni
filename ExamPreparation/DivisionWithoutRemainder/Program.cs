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
            double p2Count = 0;
            double p3Count = 0;
            double p4Count = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) p2Count++;
                if (number % 3 == 0) p3Count++;
                if (number % 4 == 0) p4Count++;
            }

            double p2 = p2Count / n * 100.00;
            double p3 = p3Count / n * 100.00;
            double p4 = p4Count / n * 100.00;
            
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");



        }
    }
}
