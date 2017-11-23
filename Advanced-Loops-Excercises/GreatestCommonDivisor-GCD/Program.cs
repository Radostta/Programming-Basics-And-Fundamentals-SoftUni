using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int bigger = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            while (smaller != 0)
            {
                int nextSmall = bigger % smaller;
                bigger = smaller;
                smaller = nextSmall;
            }

            Console.WriteLine(bigger);

            //int bigger = int.Parse(Console.ReadLine());
            //int smaller = int.Parse(Console.ReadLine());           
                    
            //while (smaller != 0)
            //{
            //    int oldSmaller = smaller;
            //    smaller = bigger % smaller;
            //    bigger = oldSmaller;
            //}
            //Console.WriteLine(bigger);
        }
    }
}
