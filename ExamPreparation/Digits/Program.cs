using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
                        
            int d1 = number % 1000 / 100;
            int d2 = number % 100 / 10;
            int d3 = number % 10 / 1;

            int rows = d1 + d2;
            int cols = d1 + d3;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (number % 5 == 0) number -= d1;
                    else if (number % 3 == 0) number -= d2;
                    else number += d3;
                    Console.Write(number + " ");                
                }
                Console.WriteLine();
            }
        }
    }
}
