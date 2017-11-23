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
            double count = double.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string orderType = Console.ReadLine();
            double bill = 0;

            if (size == "9X13")
            {
                bill += (count * 0.16);
                if (count >= 50) bill -= (bill * 0.05); 
            }
            else if (size == "10X15")
            {
                bill += (count * 0.16);
                if (count >= 80) bill -= (bill * 0.03);
            }
            else if (size == "13X18")
            {
                bill += (count * 0.38);
                if (count > 100) bill -= (bill * 0.05);
                else if (count >= 50) bill -= (bill * 0.03);
            }
            else if (size == "20X30")
            {
                bill += (count * 2.90);
                if (count > 50) bill -= (bill * 0.09);
                else if (count >= 10) bill -= (bill * 0.07);
            }

            if (orderType == "online") bill -= (bill * 0.02);

            Console.WriteLine($"{bill:f2}BGN");
        }
    }
}
