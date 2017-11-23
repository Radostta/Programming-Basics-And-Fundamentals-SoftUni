using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineDigitMagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int sumOfDigitsNum1 = 0;
            int sumOfDigitsNum2 = 0;
            int sumOfDigitsNum3 = 0;
            string firstDigits = "";
            string secondDigits = "";
            string thirdDigits = "";
            bool resultFound = false;

            for (int num1 = 111; num1 <= 777; num1++)
            {
                int num2 = num1 + diff;
                int num3 = num2 + diff;

                for (int digitsNum3 = 777; digitsNum3 > num2; digitsNum3--)
                {
                    sumOfDigitsNum3 += digitsNum3;
                    thirdDigits += digitsNum3;
                }
                for (int digitsNum2 = num2; digitsNum2 > num1; digitsNum2--)
                {
                    sumOfDigitsNum2 += digitsNum2;
                    secondDigits += digitsNum2;
                }
                for (int digitsNum1 = num1; digitsNum1 >= 1; digitsNum1--)
                {
                    sumOfDigitsNum1 += digitsNum1;
                    firstDigits += digitsNum1;
                }

                if ((num1 <= num2 && num2 <= num3) && (sumOfDigitsNum1 + sumOfDigitsNum2 + sumOfDigitsNum3 == sum))
                {
                    Console.WriteLine($"{firstDigits}{secondDigits}{thirdDigits}");
                    resultFound = true;
                }
            }

            if (resultFound = false) Console.WriteLine("No");

            //int sum = int.Parse(Console.ReadLine());
            //int diff = int.Parse(Console.ReadLine());

            //int sumAll = 0;
            //int stringFirst = 0;
            //int stringSecond = 0;
            //int stringThird = 0;
            //bool magicFound = false;


            //for (int first = 1; first <= 7; first++)
            //{
            //    for (int second = 1; second <= 7; second++)
            //    {
            //        for (int third = 1; third <= 7; third++)
            //        {
            //            for (int forth = 1; forth <= 7; forth++)
            //            {
            //                for (int fifth = 1; fifth <= 7; fifth++)
            //                {
            //                    for (int sixth = 1; sixth <= 7; sixth++)
            //                    {
            //                        for (int seventh = 1; seventh <= 7; seventh++)
            //                        {
            //                            for (int eighth = 1; eighth <= 7; eighth++)
            //                            {
            //                                for (int ninth = 1; ninth <= 7; ninth++)
            //                                {                                                
            //                                    sumAll = first + second + third + forth + fifth + sixth + seventh + eighth + ninth;
            //                                    stringFirst = int.Parse($"{first}{second}{third}");
            //                                    stringSecond = int.Parse($"{third}{forth}{fifth}");
            //                                    stringThird = int.Parse($"{sixth}{seventh}{eighth}");

            //                                    if (sumAll == sum)
            //                                    {
            //                                        if ((stringThird - stringSecond == diff) && (stringSecond - stringFirst == diff))
            //                                        {
            //                                            Console.WriteLine($"{first}{second}{third}{forth}{fifth}{sixth}{seventh}{eighth}{ninth}");
            //                                            magicFound = true;
            //                                        }
            //                                    }
                                                
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            //if (magicFound == false)
            //{
            //    Console.WriteLine("No");
            //}            
        }
    }
}
