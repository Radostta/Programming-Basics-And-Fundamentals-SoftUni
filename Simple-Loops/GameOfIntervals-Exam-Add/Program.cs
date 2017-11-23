using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double movesCount = double.Parse(Console.ReadLine());
            double result = 0.00;
            double invalidNumbers = 0.00;
            double numbers0To9 = 0.00;
            double numbers10To19 = 0.00;
            double numbers20To29 = 0.00;
            double numbers30To39 = 0.00;
            double numbers40To50 = 0.00;

            for (int currentMove = 0; currentMove < movesCount; currentMove++)
            {
                double number = double.Parse(Console.ReadLine());
               
                if (number >= 0 && number < 10)
                {
                    numbers0To9++;
                    result += number * 0.20;
                }
                else if (number >= 10 && number < 20)
                {
                    numbers10To19++;
                    result += number * 0.30;
                }
                else if (number >= 20 && number < 30)
                {
                    numbers20To29++;
                    result += number * 0.40;
                }
                else if (number >= 30 && number < 40)
                {
                    numbers30To39++;
                    result += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    numbers40To50++;
                    result += 100;
                }

                if (number < 0 || number > 50)
                {
                    invalidNumbers++;
                    result /= 2;
                }
            }

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(numbers0To9 / movesCount * 100.00):f2}%");
            Console.WriteLine($"From 10 to 19: {(numbers10To19 / movesCount * 100.00):f2}%");
            Console.WriteLine($"From 20 to 29: {(numbers20To29 / movesCount * 100.00):f2}%");
            Console.WriteLine($"From 30 to 39: {(numbers30To39 / movesCount * 100.00):f2}%");
            Console.WriteLine($"From 40 to 50: {(numbers40To50 / movesCount * 100.00):f2}%");
            Console.WriteLine($"Invalid numbers: {(invalidNumbers / movesCount * 100.00):f2}%");



        }
    }
}
