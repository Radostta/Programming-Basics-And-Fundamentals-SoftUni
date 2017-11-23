using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOrMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = int.Parse(Console.ReadLine());
            bool sumFound = false;
            bool multiplicationFound = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == control && a < b && b < c)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {control}");
                            sumFound = true;
                        }

                        if (a * b * c == control && a > b && b > c)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {control}");
                            multiplicationFound = true;
                        }
                    }
                }
            }            

            if (sumFound == false && multiplicationFound == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
