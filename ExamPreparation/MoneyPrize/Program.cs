using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyPerPoint = double.Parse(Console.ReadLine());
            
            double prize = 0;

            for (int currentPart = 1; currentPart <= parts; currentPart++)
            {
                double points = double.Parse(Console.ReadLine());

                if (currentPart % 2 == 0) prize += (points * 2);
                else prize  += points;
            }

            double money = prize * moneyPerPoint;

            Console.WriteLine($"The project prize was {money:f2} lv.");
        }
    }
}
