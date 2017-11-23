using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int sideDots = n;
            int middle = width - 2 * sideDots - 2;

            string textSideDots = new string('.', sideDots);
            char filling = '#';
            string textMiddle = new string(filling, middle);

            for (int row = 1; row <= n + 1; row++)
            {
                if (row <= n / 2)
                {
                    filling = '#';
                }
                else
                {
                    filling = '.';
                }
                Console.WriteLine("{0}#{1}#{0}", new string('.', sideDots), new string(filling, middle)); //TOP
                sideDots++;
                middle -= 2;
            }

            sideDots--;
            middle += 2;
            filling = '#';
            Console.WriteLine("{0}#{1}#{0}", new string('.', sideDots), new string(filling, middle)); //SECOND

            sideDots = sideDots - 2;
            middle = middle + 4;
            for (int row = 1; row <= n + 2; row++)
            {
                if (row == n / 2 + 1)
                {
                    int newDots = (width - 10) / 2;
                    Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', newDots)); //THIRD
                    if (newDots <= 0) Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', newDots)); //THIRD
                }
                else
                {
                    Console.WriteLine("{0}#{1}#{0}", new string('.', sideDots), new string(filling, middle)); //THIRD

                }
            }           
        }
    }
}
