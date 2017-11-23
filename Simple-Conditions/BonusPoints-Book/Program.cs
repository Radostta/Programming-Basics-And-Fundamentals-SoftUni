using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;

            if (num <= 100)
            {
                bonusScore = bonusScore + 5;
            }
            else if (num <= 1000)
            {
                bonusScore = num * 0.20;
            }
            else
            {
                bonusScore = num * 0.10;
            }

            if (num % 2 == 0)
            {
                bonusScore = bonusScore + 1;
            }
            if (num % 10 == 5)
            {
                bonusScore = bonusScore + 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}
