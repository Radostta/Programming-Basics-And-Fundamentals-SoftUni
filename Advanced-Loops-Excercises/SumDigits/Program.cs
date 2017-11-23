using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            //SOLUTION 2:
            while (n > 0)
            {
                result = result + (n % 10);
                n = n / 10;
            }
            Console.WriteLine(result);


            //SOLUTION 1:
            //do
            //{
            //    result += n % 10;
            //    n = n / 10;
            //} while (n > 0);
            //Console.WriteLine(result);

        }
    }
}
