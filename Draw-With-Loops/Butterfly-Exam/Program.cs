using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsOneSide = n - 2;
            int dashesOneSide = n - 2;
            string stars = new string('*', starsOneSide);
            string dashes = new string('-', dashesOneSide);

            //Top part
            for (int row = 0; row < n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine($"{stars}\\ /{stars}");
                }
                else
                {
                    Console.WriteLine($"{dashes}\\ /{dashes}");
                }
            }
            //Middle part
            string spaces = new string(' ', n - 1);
            Console.WriteLine($"{spaces}@");

            //Bottom part
            for (int row = 0; row < n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine($"{stars}/ \\{stars}");
                }
                else
                {
                    Console.WriteLine($"{dashes}/ \\{dashes}");
                }
            }
        }
    }
}
