using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums3Numbers_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sumOfThree = n1 + n2 + n3;
            int biggest = Math.Max(n1, Math.Max(n2, n3));
            int smallest = Math.Min(n1, Math.Min(n2, n3));
            int mid = sumOfThree - biggest - smallest;

            if (smallest + mid == biggest)
            {
                Console.WriteLine($"{smallest} + {mid} = {biggest}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
