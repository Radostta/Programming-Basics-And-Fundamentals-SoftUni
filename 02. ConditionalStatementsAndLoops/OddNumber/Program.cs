using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {   
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                n = Math.Abs(n);

                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {n}");
                    break;
                }

            }
        }
    }
}
