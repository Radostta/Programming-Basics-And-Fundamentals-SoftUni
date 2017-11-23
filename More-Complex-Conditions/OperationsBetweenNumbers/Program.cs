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
            var n1 = decimal.Parse(Console.ReadLine());
            var n2 = decimal.Parse(Console.ReadLine());
            var nOperator = Console.ReadLine();
            
            decimal result = 0.00m;
            
            if (n2 == 0 && (nOperator == "/" || nOperator == "%"))
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else if (nOperator == "/")
            {
                result = n1 / n2;
                Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
            }
            else if (nOperator == "%")
            {
                result = n1 % n2;
                Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
            }
            else
            {
                if (nOperator == "+")
                {
                    result = n1 + n2;
                }
                else if (nOperator == "-")
                {
                    result = n1 - n2;
                }
                else if (nOperator == "*")
                {
                    result = n1 * n2;
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, nOperator, n2, result, result % 2 == 0 ? "even" : "odd");
            }

        }
    }
}
