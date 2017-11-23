using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 1;
            int second = 1;

            for (int i = 2; i <= n; i++)
            {
                int newFirst = first + second;
                second = first;
                first = newFirst;              
            }
            Console.WriteLine(first);
        }
    }
}
