using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersExcercise
{
    class PrintNumbersExcercise
    {
        static void Main(string[] args)
        {
            PrintNumbersSequence(5, 10);
            PrintNumbersSequence(50, 80);

            Console.WriteLine();

            for (int i = 1; i <= 20; i++)
            {
                PrintNumbersSequence(1, i);
            }

            Console.WriteLine();

            var n1 = 10;
            for (int i = 1; i < n1; i++)
            {
                PrintNumbersSequence(1, i);
            }
            for (int i = n1; i >= 1; i--)
            {
                PrintNumbersSequence(1, i);
            }

            Console.WriteLine();

            var n2 = 5;
            for (int i = 1; i < n2; i++)
            {
                PrintNumbersFromDefault();
            }
            for (int i = n2; i >= 1; i--)
            {
                PrintNumbersFromDefault(5);
            }
            for (int i = n2; i >= 1; i--)
            {
                PrintNumbersFromDefault(2, n2);
            }
            for (int i = n2; i >= 1; i--)
            {
                PrintNumbersFromDefault(end: 10, start: 2);
            }
        }

        static void PrintNumbersSequence(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void PrintNumbersFromDefault(int start = 1, int end = 10)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
