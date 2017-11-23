using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            int height = n;
            int columnsInside = n / 2;
            int middle = width - columnsInside * 2 - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', columnsInside), new string('_', middle)); // print first row

            string spaces = new string(' ', 2 * n - 2);
            if (n == 3 || n == 4) // print body
            {
                for (int row = 1; row <= n / 2; row++) Console.WriteLine($"|{spaces}|");                
            }
            else
            {
                for (int row = 1; row <= n - 3; row++) Console.WriteLine($"|{spaces}|");                
            }

            if (n > 4) Console.WriteLine("|{0}{1}{0}|", new string(' ', columnsInside + 1), new string('_', middle)); //print last body row
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', columnsInside), new string(' ', middle)); // print last row
           

        }
    }
}
