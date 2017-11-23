using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string answers = "";
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 4 == 0)
                {
                    //answers += ((char)97 + " ");  
                    answers += ("a ");
                    aCount++;
                }
                else if (number % 4 == 1)
                {
                    //answers += (char)98 + " ";
                    answers += ("b ");
                    bCount++;
                }
                else if (number % 4 == 2)
                {
                    //answers += (char)99 + " ";
                    answers += ("c ");
                    cCount++;
                }
                else if (number % 4 == 3)
                {
                    answers += ("d ");
                    dCount++;
                }
            }

            Console.WriteLine(answers);

            Console.WriteLine("Answer A: " + aCount);
            Console.WriteLine("Answer B: " + bCount);
            Console.WriteLine("Answer C: " + cCount);
            Console.WriteLine("Answer D: " + dCount);

        }
    }
}
