using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 1;
            int second = 1;

            for (int i = 2; i <= n; i++) // == (int = 0; i < n-1; i++)
            {
                int next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine(second);
            
            //Solution 1:
            //int n = int.Parse(Console.ReadLine());
            //int small = 0;
            //int big = 1;
            //int newBig = 0;
            //if (n < 2)
            //{
            //    newBig = 1;
            //}

            //for (int i = 1; i <= n; i++)
            //{                
            //        newBig = small + big;
            //        small = big;
            //        big = newBig;                                                
            //}
            //Console.WriteLine(newBig);
        }
    }
}
