using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            bool isBetween0and500 = sales >= 0 && sales <= 500;
            bool isBetween500and1000 = sales > 500 && sales <= 1000;
            bool isBetween1000and10000 = sales > 1000 && sales <= 10000;
            bool isGreaterThan10000 = sales > 10000;

            double commissionPercent = 0.0;

            if (town == "Sofia")
            {
                if (isBetween0and500)
                {
                    commissionPercent = 0.05;
                }
                else if (isBetween500and1000)
                {
                    commissionPercent = 0.07;
                }
                else if (isBetween1000and10000)
                {
                    commissionPercent = 0.08;
                }
                else if (isGreaterThan10000)
                {
                    commissionPercent = 0.12;
                }
            }
            else if (town == "Varna")
            {
                if (isBetween0and500)
                {
                    commissionPercent = 0.045;
                }
                else if (isBetween500and1000)
                {
                    commissionPercent = 0.075;
                }
                else if (isBetween1000and10000)
                {
                    commissionPercent = 0.10;
                }
                else if (isGreaterThan10000)
                {
                    commissionPercent = 0.13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (isBetween0and500)
                {
                    commissionPercent = 0.055;
                }
                else if (isBetween500and1000)
                {
                    commissionPercent = 0.08;
                }
                else if (isBetween1000and10000)
                {
                    commissionPercent = 0.12;
                }
                else if (isGreaterThan10000)
                {
                    commissionPercent = 0.145;
                }
            }

            if (commissionPercent == 0.0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{sales * commissionPercent:f2}");
            }

        }
    }
}
