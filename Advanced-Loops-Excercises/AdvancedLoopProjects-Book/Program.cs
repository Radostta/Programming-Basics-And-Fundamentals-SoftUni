using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLoopProjects1To10_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check prime
            int n = int.Parse(Console.ReadLine());
            bool isPrime = n >= 2;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }

            ////Sum Digits
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //do
            //{
            //    sum += (n % 10);
            //    n = n / 10;
            //}
            //while (n > 0);
            //Console.WriteLine(sum);

            ////Factorial
            //int n = int.Parse(Console.ReadLine());
            //int fact = 1;            
            //do
            //{
            //    fact = fact * n;
            //    n--;

            //} while (n > 1);
            //Console.WriteLine(fact);

            ////GDC - Greatest Common Divisor
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //while (b != 0)
            //{
            //    int nextB = a % b;
            //    a = b;
            //    b = nextB;
            //}
            //Console.WriteLine(a);

            ////Numbers in range [1... 100]
            //int n = int.Parse(Console.ReadLine());

            //while (n < 1 || n > 100)
            //{
            //    Console.WriteLine("Invalid number!");
            //    n = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The number is: " + n);

            ////Sequence 2k + 1
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;

            //while (num <= n)
            //{
            //    Console.WriteLine(num);
            //    num = num * 2 + 1;
            //}

            ////Even powers of 2
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;

            //for (int i = 0; i <= n; i+=2)
            //{
            //    Console.WriteLine(num);
            //    num *= 2 * 2;
            //}

            ////Powers of 2
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;

            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(num);
            //    num *= 2;
            //}

            ////Numbers n to 1
            //int n = int.Parse(Console.ReadLine());

            //for (int i = n; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            ////Numbers 1 to n with step 3
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
