using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine().ToLower();
            double price = 0;
            double taxiValue = 0;

            //double taxiValue = timeOfTheDay == "day" ? 0.79 : 0.90;

            if (timeOfTheDay == "day")
            {
                taxiValue += 0.79;
            }
            else if (timeOfTheDay == "night")
            {
                taxiValue += 0.90;
            }
        

            if (km < 20)
            {
                price = 0.70 + km * taxiValue;
            }
            else if (km < 100)
            {
                price = km * 0.09;
            }
            else
            {
                price = km * 0.06;
            }

            Console.WriteLine($"{price:f2}");


        }
    }
}
