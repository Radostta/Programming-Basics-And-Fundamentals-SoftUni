using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Refactor the following code:

            //int ___Do___ = int.Parse(Console.ReadLine());
            //for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
            //{
            //    bool TowaLIE = true;
            //    for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
            //    {
            //        if (DAVIDIM % delio == 0)
            //        {
            //            TowaLIE = false;
            //            break;
            //        }
            //    }
            //    Console.WriteLine($"{DAVIDIM} -> {TowaLIE}");
            //}


            int n = int.Parse(Console.ReadLine());
                     
            for (int currentNumber = 2; currentNumber <= n; currentNumber++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(currentNumber); divisor++)
                {
                    if (currentNumber % divisor == 0)
                    {
                        isPrime = false;                        
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }

        }
    }
}
