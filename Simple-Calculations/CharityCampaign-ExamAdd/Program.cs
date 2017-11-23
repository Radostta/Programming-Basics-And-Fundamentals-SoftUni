
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysCount = double.Parse(Console.ReadLine());
            double cooksCount = double.Parse(Console.ReadLine());
            double cakesCount = double.Parse(Console.ReadLine());
            double waferCount = double.Parse(Console.ReadLine());
            double pancakesCount = double.Parse(Console.ReadLine());

            double allCount = cakesCount * 45.00 + waferCount * 5.80 + pancakesCount * 3.20;
            double income = allCount * cooksCount * daysCount;
            income -= income / 8;

            Console.WriteLine($"{income:f2}");



        }
    }
}
