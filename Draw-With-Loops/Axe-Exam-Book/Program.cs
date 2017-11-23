using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int stars = 2;
            int leftDashes = n * 3;
            int rightDashes = width - leftDashes - stars;
            int middle = 0;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middle), new string('-', rightDashes)); //print top part
                middle++;
                rightDashes--;
            }

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes), new string('-', middle-1), new string('-', rightDashes+1)); //print mid part
            }

            for (int row = 1; row <= n / 2; row++)
            {
                if (row == n / 2)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', middle - 1), new string('-', rightDashes + 1)); //print bottom part

                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middle - 1), new string('-', rightDashes + 1)); //print bottom part

                }
                leftDashes--;
                middle = middle + 2;
                rightDashes--;
  
            }

            
            //Console.WriteLine("{0}**{1}**{2}", new string('-', leftDashes-1), new string('*', middle - 2), new string('-', rightDashes)); //print last line


        }
    }
}
