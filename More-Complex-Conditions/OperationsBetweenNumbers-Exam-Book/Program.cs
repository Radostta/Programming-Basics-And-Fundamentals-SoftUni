using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = decimal.Parse(Console.ReadLine());
            var n2 = decimal.Parse(Console.ReadLine());
            var nOperator = Console.ReadLine();
            decimal result = 0.00m;
            string output = string.Empty;

            if (n2 == 0 && (nOperator.Equals("/") || nOperator.Equals("%")))
            {
                output = string.Format($"Cannot divide {n1} by zero");
            }
            else if (nOperator.Equals("/"))
            {
                result = n1 / n2;
                output = string.Format($"{n1} {nOperator} {n2} = {result:f2}");
            }
            else if (nOperator.Equals("%"))
            {
                result = n1 % n2;
                output = string.Format($"{n1} {nOperator} {n2} = {result}");
            }
            else
            {
                if (nOperator.Equals("*"))
                {
                    result = n1 * n2;
                }
                else if (nOperator.Equals("+"))
                {
                    result = n1 + n2;
                }
                else if (nOperator.Equals("-"))
                {
                    result = n1 - n2;
                }
                output = string.Format("{0} {1} {2} = {3} - {4}", n1, nOperator, n2, result, result % 2 == 0 ? "even" : "odd");
            }

            Console.WriteLine(output);
        }
    }
}
