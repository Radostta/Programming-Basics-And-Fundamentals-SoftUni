using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());
            double dolls = double.Parse(Console.ReadLine());
            double bears = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());

            double income = puzzles * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;
            double toyCount = puzzles + dolls + bears + minions + trucks;
            if (toyCount >= 50)
            {
                income -= income * 0.25;
            }
            income -= income * 0.10;

            if (income >= tripPrice)
            {
                Console.WriteLine($"Yes! {(income - tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice - income):f2} lv needed.");
            }

        }
    }
}
