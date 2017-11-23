using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double adults = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            string transportMeans = Console.ReadLine();

            double peopleTotal = adults + students;
            double transportPrice = 0.0;            

            if (transportMeans == "train")
            {
                if (peopleTotal >= 50)
                {
                    transportPrice = (adults * 24.99 + students * 14.99) / 2.0;
                }
                else
                {
                    transportPrice = (adults * 24.99 + students * 14.99);
                }
            }
            else if (transportMeans == "bus")
            {
                transportPrice = adults * 32.50 + students * 28.50;
            }
            else if (transportMeans == "boat")
            {
                transportPrice = adults * 42.99 + students * 39.99;
            }
            else if (transportMeans == "airplane")
            {
                transportPrice = adults * 70.00 + students * 50.00;
            }

            double totalPrice = nights * 82.99 + transportPrice * 2;
            totalPrice += totalPrice * 0.10;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
