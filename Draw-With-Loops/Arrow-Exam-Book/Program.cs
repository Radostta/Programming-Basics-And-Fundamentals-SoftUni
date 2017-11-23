using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sideDots = (n - 1) / 2;
            int middle = n - 2;
            for (int row = 0; row < n-1; row++)
            {
                if (row == 0) Console.WriteLine("{0}#{1}#{0}", new string('.', sideDots), new string('#', middle)); //print top part
                else Console.WriteLine("{0}#{1}#{0}", new string('.', sideDots), new string('.', middle));
            }
            
            Console.WriteLine("{0}#{1}#{0}", new string('#', sideDots), new string('.', middle)); //print mid line

            int newMiddle = 2 * middle - 1;
            for (int leftRightDots = 1; leftRightDots <= n-1; leftRightDots++)
            {                
                if (newMiddle <= 0)
                {
                    Console.WriteLine("{0}#{0}", new string('.', leftRightDots)); //print last line
                }
                else
                {
                    Console.WriteLine("{0}#{1}#{0}", new string('.', leftRightDots), new string('.', newMiddle)); //print bottom part
                }
                newMiddle = newMiddle - 2;
            }

        }
    }
}
