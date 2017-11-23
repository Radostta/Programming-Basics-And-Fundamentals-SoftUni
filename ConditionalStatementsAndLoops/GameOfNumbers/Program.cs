using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool combinationFound = false;

            for (int n1 = m; n1 >= n; n1--)
            {
                for (int n2 = m; n2 >= n; n2--)
                {
                    combinations++;
                    if (n1 + n2 == magic)
                    {
                        Console.WriteLine($"Number found! {n1} + {n2} = {magic}");
                        combinationFound = true;
                        return;
                    }
                }                
            }

            Console.WriteLine($"{combinations} combinations - neither equals {magic}");
           
        }
    }
}
