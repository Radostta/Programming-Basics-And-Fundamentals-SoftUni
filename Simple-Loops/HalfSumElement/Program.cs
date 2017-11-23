using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sumNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sumNumbers += number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }                
            }

            int restNumbers = sumNumbers - maxNumber;
            int diff = Math.Abs(maxNumber - restNumbers);

            if (maxNumber == restNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
