using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            decimal nightsCount = decimal.Parse(Console.ReadLine());
            decimal studioPerNight = 0m;
            decimal doublePerNight = 0m;
            decimal suitePerNight = 0m;
      
            if (month == "May" || month == "October")
            {
                studioPerNight = 50m;
                doublePerNight = 65m;
                suitePerNight = 75m;

                if (nightsCount > 7m)
                {
                    studioPerNight -= studioPerNight * 0.05m;
                }               
            }
            else if (month == "June" || month == "September")
            {
                studioPerNight = 60m;
                doublePerNight = 72m;
                suitePerNight = 82m;

                if (nightsCount > 14m)
                {
                    doublePerNight -= doublePerNight * 0.10m;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPerNight = 68m;
                doublePerNight = 77m;
                suitePerNight = 89m;

                if (nightsCount > 14m)
                {
                    suitePerNight -= suitePerNight * 0.15m;
                }
            }

            decimal studioPrice = 0m;
            decimal doublePrice = doublePerNight * nightsCount;
            decimal suitePrice = suitePerNight * nightsCount;
            
            if (nightsCount > 7m && (month == "September" || month == "October"))
            {
                studioPrice = studioPerNight * (nightsCount - 1m);
            }
            else
            {
                studioPrice = studioPerNight * nightsCount;
            }
            

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");


        }
    }
}
