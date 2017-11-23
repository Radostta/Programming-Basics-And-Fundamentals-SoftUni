using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            bool isPrime = n > 1;

            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

            ////SOLUTION 2:
            //int n = int.Parse(Console.ReadLine());
            //bool isPrime = true;
            //for (int i = 2; i <= Math.Sqrt(n); i++) // from 2 to -n
            //{
            //    if (n % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}

            //if (n < 2)
            //{
            //    isPrime = false;
            //}
            //if (isPrime) Console.WriteLine("Prime");
            //else Console.WriteLine("Not Prime");

            //SOLUTION 1:
            //int n = int.Parse(Console.ReadLine());
            //bool isPrime = true;
            //for (int i = 2; i < n; i++) // from 2 to -n
            //{
            //    if (n % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}

            //if (n < 2)
            //{
            //    isPrime = false;
            //}

            //if (isPrime) Console.WriteLine("Prime");
            //else Console.WriteLine("Not Prime");

        }
    }
}
