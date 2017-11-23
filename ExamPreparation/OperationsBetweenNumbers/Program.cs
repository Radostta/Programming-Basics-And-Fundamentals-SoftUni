using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string nOperator = (Console.ReadLine());
            int result = 0;

            if ((nOperator == "/" || nOperator == "%") && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (nOperator == "%")
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
            else if (nOperator == "/")
            {
                double resultCasted = (double)n1 / (double)n2;                
                Console.WriteLine($"{n1} / {n2} = {resultCasted:f2}");
            }
            else
            {
                if (nOperator == "+")
                {
                    result = n1 + n2;
                    Console.Write($"{n1} + {n2} = {result} - ");
                }                
                else if (nOperator == "-")
                {
                    result = n1 - n2;
                    Console.Write($"{n1} - {n2} = {result} - ");
                }
                else if (nOperator == "*")
                {
                    result = n1 * n2;
                    Console.Write($"{n1} * {n2} = {result} - ");
                }

                if (result % 2 == 0) Console.WriteLine("even");
                else Console.WriteLine("odd");
            }

        }
    }
}
