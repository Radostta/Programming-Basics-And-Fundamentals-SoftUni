using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            double photos = double.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string orderType = Console.ReadLine();
            double bill = 0.00;

            if (size == "9X13")
            {
                bill = photos * 0.16;
                if (photos >= 50)
                {
                    bill -= bill * 0.05;
                }
            }
            else if (size == "10X15")
            {
                bill = photos * 0.16;
                if (photos >= 80)
                {
                    bill -= bill * 0.03;
                }
            }
            else if (size == "13X18")
            {
                bill = photos * 0.38;
                if (photos >= 50 && photos <= 100)
                {
                    bill -= bill * 0.03;
                }
                else if (photos > 100)
                {
                    bill -= bill * 0.05;
                }
            }
            else if (size == "20X30")
            {
                bill = photos * 2.90;
                if (photos >= 10 && photos <= 50)
                {
                    bill -= bill * 0.07;
                }
                else if (photos > 50)
                {
                    bill -= bill * 0.09;
                }
            }

            if (orderType == "online")
            {
                bill -= bill * 0.02;
            }

            Console.WriteLine($"{bill:f2}BGN");
        }
    }
}
