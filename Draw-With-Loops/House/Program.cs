using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n;

            //Roof
            for (int dashesCount = (n - 1) / 2; dashesCount >= 0; dashesCount--)
            {
                string dashes = new string('-', dashesCount);
                string stars = new string('*', width - dashesCount * 2);

                Console.WriteLine($"{dashes}{stars}{dashes}");
            }

            //Base
            for (int row = 0; row < n - (n + 1) / 2; row++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }

            //int width = n;
            //int dashesCount = (n - 1) / 2;

            ////Roof
            //for (int row = 0; row < (n + 1) / 2; row++)
            //{
            //    string dashes = new string('-', dashesCount);
            //    string stars = new string('*', width - dashesCount * 2);

            //    Console.WriteLine($"{dashes}{stars}{dashes}");
            //    dashesCount--;             
            //}

            ////Base
            //for (int row = 0; row < n - (n + 1) / 2; row++)
            //{
            //    Console.WriteLine("|{0}|", new string('*', n - 2));
            //}            

            //int width = n;
            //int starsCount = 1;
            //if (n % 2 == 0)
            //{
            //    starsCount++;
            //}

            ////Roof
            //for (int row = 0; row < (n + 1) / 2; row++)
            //{
            //    string dashes = new string('-', (width - starsCount) / 2);
            //    string stars = new string('*', starsCount);

            //    Console.WriteLine($"{dashes}{stars}{dashes}");
            //    starsCount += 2;
            //}

            ////Base
            //for (int row = 0; row < n - (n + 1) / 2; row++)
            //{
            //    Console.WriteLine("|{0}|", new string ('*', n-2));
            //}
        }
    }
}
