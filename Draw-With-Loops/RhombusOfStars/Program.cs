using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Top Part
            for (int row = 1; row <= n; row++)
            {
                for (int spaces = 0; spaces < n-row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Bottom Part
            for (int row = 1; row <= n-1; row++)
            {
                for (int spaces = 0; spaces < row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < n - row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
           
            
           
        }
    }
}
