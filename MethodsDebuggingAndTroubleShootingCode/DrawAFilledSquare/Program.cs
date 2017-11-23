using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderOrFooter(n);

            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddleRow(n);
            }            

            PrintHeaderOrFooter(n);

        }

        static void PrintHeaderOrFooter(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }                
    }
}
