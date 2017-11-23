using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double money = 0.00;

            if (place == "Bulgaria")
            {
                money += (points * dancers);

                if (season == "summer")
                {
                    money -= (money * 0.05);
                }
                else
                {
                    money -= (money * 0.08);
                }
            }
            else
            {
                money += (points * dancers);
                money += (money * 0.50);

                if (season == "summer")
                {
                    money -= (money * 0.10);
                }
                else
                {
                    money -= (money * 0.15);
                }
            }

            double charity = money * 0.75;
            money -= charity;
            
            double moneyPerDancer = money / dancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");



            
        }
    }
}
