using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int bigger = Math.Max(n1, n2);
            int smaller = Math.Min(n1, n2);


            for (int num = smaller; num <= bigger; num++)
            {
                Console.WriteLine(num);
            }
        }
    }
}
