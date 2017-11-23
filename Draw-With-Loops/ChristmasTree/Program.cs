using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                string stars = new string('*', i);
                string spaces = new string(' ', n - i);
                Console.WriteLine($"{spaces}{stars} | {stars}{spaces}");
            }
            //string middle = " | ";         

            //for (int row = 0; row <= n; row++)
            //{
            //    string spaces = "";
            //    string stars = "";
            //    for (int sp = 0; sp < n - row; sp++)
            //    {
            //        spaces += " ";
            //    }
            //    for (int st = 0; st < row; st++)
            //    {
            //        stars += "*";
            //    }
            //    Console.WriteLine("{0}{1}{2}{1}", spaces, stars, middle, stars);
            //}
        }
    }
}
