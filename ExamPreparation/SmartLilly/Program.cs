using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            double lillysAge = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double incomePerPresent = double.Parse(Console.ReadLine());
            double money = 0.00;
            double savings = 0.00;
            double presents = 0.00;

            for (int birthday = 1; birthday <= lillysAge; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    money += 10;
                    savings += money - 1;                    
                }
                else
                {
                    presents++;
                }
            }

            savings += presents * incomePerPresent;
            double difference = Math.Abs(savings - price);

            if (savings < price)
            {
                Console.WriteLine("No! {0:f2}", difference);
            }
            else
            {
                Console.WriteLine("Yes! {0:f2}", difference);
            }
        }
    }
}
