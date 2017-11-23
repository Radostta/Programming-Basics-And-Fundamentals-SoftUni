using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (number <= 100)
            {
                bonus = bonus + 5;

            }

            else if (number <= 1000)
            {
                bonus = bonus + number * 0.2;

            }

            else if (number > 1000)
            {
                bonus = bonus + number * 0.1;

            }

            if (number % 2 == 0)
            {
                bonus++;
            }
           
            if (number % 10 == 5)
            {
                //bonus = bonus + 2;
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);

        }

    }
}
