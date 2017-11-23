using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int rowsCount = (number % 1000 / 100) + (number % 100/ 10);
            int colsCount = (number % 1000 / 100) + (number % 10);
            int firstDigit = number % 1000 / 100;
            int secondDigit = number % 100 / 10;
            int thirdDigit = number % 10;

            for (int rows = 1; rows <= rowsCount; rows++)
            {
                for (int cols = 0; cols < colsCount; cols++)
                {
                    if (number % 5 == 0)
                    {
                        number -= (firstDigit);
                    }
                    else if (number % 3 == 0)
                    {
                        number -= (secondDigit);
                    }
                    else
                    {
                        number += (thirdDigit);
                    }
                    Console.Write(number + " ");                    
                }
                Console.WriteLine();
            }

        }
    }
}
