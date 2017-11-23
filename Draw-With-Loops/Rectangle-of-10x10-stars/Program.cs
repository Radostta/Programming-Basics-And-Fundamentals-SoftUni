using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10x10_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int rows = 1; rows <= 10; rows++)
            {
                Console.Write("*");

                for (int cols = 1; cols < 10; cols++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(new string('*', 10));
            //}
        }
    }
}
