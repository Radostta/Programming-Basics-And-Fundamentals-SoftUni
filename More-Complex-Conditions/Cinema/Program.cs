using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectionType = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            decimal seats = rows * cols;
            decimal fullHallIncome = -1.00m;

            if (projectionType == "Premiere")
            {
                fullHallIncome = seats * 12m;
            }
            else if (projectionType == "Normal")
            {
                fullHallIncome = seats * 7.50m;
            }
            else if (projectionType == "Discount")
            {
                fullHallIncome = seats * 5.00m;

            }

            Console.WriteLine($"{fullHallIncome:f2} {"leva"}");
        }
    }
}