using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starsCount = n - 2;
            for (int row = 0; row < n / 2; row++)
            {
                int outDotsCount = row;
                Console.WriteLine("{0}\\{1}/{0}", new string('.', outDotsCount), new string('*', starsCount));
                starsCount -= 2;
            }

            //bottom part:
            int outside = n / 2 - 1;

            if (n < 12)
            {
                for (int row = 0; row < (n / 2 - 1); row++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', outside));
                }
            }
            else
            {
                for (int row = 0; row < (n / 2 - 2); row++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', outside));
                }
            }

            if (n < 12)
            {
                Console.WriteLine(new string('-', n));
            }
            else
            {
                Console.WriteLine(new string('-', n));
                Console.WriteLine(new string('-', n));
            }
            
        }
    }
}
