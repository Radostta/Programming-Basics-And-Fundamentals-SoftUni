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
            double km = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;

            if (km < 20)
            {
                if (dayOrNight == "day")
                {
                    price = km * 0.79 + 0.70;
                }
                else
                {
                    price = km * 0.90 + 0.70;
                }                
            }  
            else if (km < 100)
            {
                price = km * 0.09;
            }
            else
            {
                price = km * 0.06;
            }
            Console.WriteLine(price);
        }
    }
}
