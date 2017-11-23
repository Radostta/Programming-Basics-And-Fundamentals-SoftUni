using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrys = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double tulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isItHoliday = Console.ReadLine();
            double allFlowers = chrys + roses + tulips;
            double totalBill = 0.00;

            if (season == "Spring" || season == "Summer")
            {
                totalBill += (chrys * 2.00 + roses * 4.10 + tulips * 2.50);
            }
            else if (season == "Autumn" || season == "Winter")
            {
                totalBill += (chrys * 3.75 + roses * 4.50 + tulips * 4.15);
            }

            if (isItHoliday == "Y")
            {
                totalBill += totalBill * 0.15;             
            }          

            if (season == "Spring" && tulips > 7)
            {
                totalBill -= totalBill * 0.05;
            }
            else if (season == "Winter" && roses >= 10)
            {
                totalBill -= totalBill * 0.10;
            }

            if (allFlowers > 20)
            {
                totalBill -= totalBill * 0.20;
            }

            Console.WriteLine($"{(totalBill + 2):f2}");

        }
    }
}
