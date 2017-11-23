using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double monthsCount = double.Parse(Console.ReadLine());
            double electricity = 0.00;
            double water = 0.00;
            double internet = 0.00;
            double others = 0.00;
            double allBills = 0.00;

            for (int currentMonth = 0; currentMonth < monthsCount; currentMonth++)
            {
                double ElectricityBill = double.Parse(Console.ReadLine());
                electricity += ElectricityBill;
                water += 20.00;
                internet += 15.00;
                others += (ElectricityBill + 20 + 15) + (ElectricityBill + 20 + 15) * 0.20;
                allBills += (ElectricityBill + 20 + 15) * 2 + (ElectricityBill + 20 + 15) * 0.20;
            }

            double avrMonth = allBills / monthsCount;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {avrMonth:f2} lv");

        }
    }
}
