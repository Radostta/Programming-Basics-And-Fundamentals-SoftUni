using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupName_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine()); //capital
            char secondLetter = char.Parse(Console.ReadLine()); //small
            char thirdLetter = char.Parse(Console.ReadLine()); //small
            char forthLetter = char.Parse(Console.ReadLine()); //small
            int d = int.Parse(Console.ReadLine()); //digit

            //string name = ($"{firstLetter}{secondLetter}{thirdLetter}{forthLetter}{d}");
            //string combination = "";
            int combinations = 0;
            bool isNameFound = false;

            for (char first = 'A'; first <= firstLetter; first++)
            {                
                for (char second = 'a'; second <= secondLetter; second++)
                {
                    for (char third = 'a'; third <= thirdLetter; third++)
                    {
                        for (char forth = 'a'; forth <= forthLetter; forth++)
                        {
                            for (int digit = 0; digit <= d; digit++)
                            {
                                combinations++;
                                if (firstLetter == first && secondLetter == second && thirdLetter == third && forthLetter == forth && d == digit)
                                {
                                    isNameFound = true;
                                    break;
                                }
                            }
                            if (isNameFound == true) break;
                        }
                        if (isNameFound == true) break;
                    }
                    if (isNameFound == true) break;
                }
                if (isNameFound == true) break;
            }

            Console.WriteLine(combinations - 1);
        }
    }
}
