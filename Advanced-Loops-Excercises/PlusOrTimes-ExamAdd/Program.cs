using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOrTimes_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int special = int.Parse(Console.ReadLine());           
            bool isSummed = false;
            bool isMultiplied = false;

            for (int first = 1; first <= 30; first++)
            {
                for (int second = 1; second <= 30; second++)
                {
                    for (int third = 1; third <= 30; third++)
                    {
                        if (first < second && second < third)
                        {
                            if (first + second + third == special)
                            {
                                isSummed = true;
                                Console.WriteLine($"{first} + {second} + {third} = {special}");
                            }
                        }
                        if (first > second && second > third)
                        {
                            if (first * second * third == special)
                            {
                                isMultiplied = true;
                                Console.WriteLine($"{first} * {second} * {third} = {special}");
                            }
                        }                                                
                    }
                }
            }

            if (isSummed == false && isMultiplied == false) Console.WriteLine("No!");
        }
    }
}
