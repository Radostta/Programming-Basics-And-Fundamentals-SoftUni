using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1_100
{
    class Program
    {
        static void Main(string[] args)
        {

            //with TRY-CATCH

            var num = -1;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num >= 1 && num <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid number!");
                }
                catch
                {

                    Console.WriteLine("This is not a number. Try again.");
                }
            }
            Console.WriteLine("The number is: " + num);            

            /*SOLUTION:
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + num);*/

        }
    }
}
