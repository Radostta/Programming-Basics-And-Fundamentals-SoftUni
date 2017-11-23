using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnolias = double.Parse(Console.ReadLine());
            double hyacinths = double.Parse(Console.ReadLine()); //zyumbyul
            double roses = double.Parse(Console.ReadLine());
            double cactuses = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double income = magnolias * 3.25 + hyacinths * 4 + roses * 3.50 + cactuses * 8;
            income -= income * 0.05;

            if (income >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(income - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - income)} leva.");
            }

        }
    }
}
