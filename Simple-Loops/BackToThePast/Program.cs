using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int lastYear = int.Parse(Console.ReadLine());
            int age = 18;


            for (int currentYear = 1800; currentYear <= lastYear; currentYear++)
            {

                if (currentYear % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= (12000 + (age * 50));
                }
                age++;
            }

            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(money):f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {(Math.Abs(money)):f2} dollars to survive.");
            }

            //double money = double.Parse(Console.ReadLine());
            //int lastYear = int.Parse(Console.ReadLine());
            //int age = 18;


            //for (int i = 1800; i <= lastYear; i++)
            //{

            //    if (i % 2 == 0)
            //    {                                       
            //        money -= 12000;
            //        age++;
            //    }
            //    else
            //    {
            //        money -= (12000 + (age * 50));
            //        age++;
            //    }
            //}           

            //if (money >= 0)
            //{
            //    Console.WriteLine($"Yes! He will live a carefree life and will have {(money):f2} dollars left.");
            //}
            //else
            //{
            //    Console.WriteLine($"He will need {(money * -1):f2} dollars to survive.");
            //}
        }
    }
}
