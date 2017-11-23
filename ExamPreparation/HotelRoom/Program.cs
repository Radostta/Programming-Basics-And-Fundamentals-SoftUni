using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double apartment = 0.00;
            double studio = 0.00;

            if (month == "May" || month == "October")
            {
                studio = 50.00;
                apartment = 65.00;
                                  
                if (nightsCount > 14)
                {
                    apartment -= apartment * 0.10;
                    studio -= studio * 0.30;
                }
                else if (nightsCount > 7)
                {
                    studio -= studio * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
               
                if (nightsCount > 14)
                {
                    apartment -= apartment * 0.10;
                    studio -= studio * 0.20;
                }                    
            }
            else if (month == "July" || month == "August")
            {
                studio = 76.00;
                apartment = 77.00;

                if (nightsCount > 14)
                {
                    apartment -= apartment * 0.10;
                }                    
            }

            double sTotal = studio * nightsCount;
            double aTotal = apartment * nightsCount;

            Console.WriteLine($"Apartment: {aTotal:f2} lv.");
            Console.WriteLine($"Studio: {sTotal:f2} lv.");
        }
    }
}
