using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var apartmentPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;

                    if (nights > 14)
                    {
                        studioPrice -= 50 * 0.3;
                        apartmentPrice -= 65 * 0.1;
                    }
                    else if (nights > 7)
                    {
                        studioPrice -= 50 * 0.05;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;

                    if (nights > 14)
                    {
                        studioPrice -= 75.20 * 0.2;
                        apartmentPrice -= 68.70 * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00;
                    apartmentPrice = 77.00;

                    if (nights > 14)
                    {
                        apartmentPrice -= 77.00 * 0.1;
                    }
                    break;
            }

            double totalApartmentPrice = apartmentPrice * nights;
            double totalStudioPrice = studioPrice * nights;

            Console.WriteLine("Apartment: {0:F2} lv.", totalApartmentPrice);
            Console.WriteLine("Studio: {0:F2} lv.", totalStudioPrice);
            
            
            //ERROR:
            //var month = Console.ReadLine().ToLower();
            //var nights = decimal.Parse(Console.ReadLine());
            //var studioPrice = 50.00m;
            //var apartmentPrice = 65.00m;
            //var studioRent = 0.00m;
            //var apartmentRent = 0.00m;

            //if (month == "may" || month == "octomber")
            //{
            //    studioPrice = 50.00m;
            //    apartmentPrice = 65.00m;

            //    studioRent = studioPrice * nights;
            //    apartmentRent = apartmentPrice * nights;

            //    if (nights > 14)
            //    {
            //        studioRent *= 0.70m;
            //        apartmentRent *= 0.90m;
            //    }
            //    else if (nights > 7)
            //    {
            //        studioRent *= 0.95m;
            //    }
            //}
            //else if (month == "june" || month == "september")
            //{
            //    studioPrice = 75.20m;
            //    apartmentPrice = 68.70m;

            //    studioRent = studioPrice * nights;
            //    apartmentRent = apartmentPrice * nights;

            //    if (nights > 14)
            //    {
            //        studioRent *= 0.80m;
            //        apartmentRent *= 0.90m;
            //    }                
            //}
            //else if (month == "july" || month == "august")
            //{
            //    studioPrice = 76m;
            //    apartmentPrice = 77m;

            //    studioRent = studioPrice * nights;
            //    apartmentRent = apartmentPrice * nights;

            //    if (nights > 14)
            //    {
            //        apartmentRent *= 0.90m;
            //    }
            //}
            //var studioInfo = string.Format("Studio: {0:f2} lv.", decimal.Round(studioRent, 2));
            //var apartmentInfo = string.Format("Apartment: {0:f2} lv.", decimal.Round(apartmentRent, 2));

            //Console.WriteLine(apartmentInfo);
            //Console.WriteLine(studioInfo);
        }
    }
}
