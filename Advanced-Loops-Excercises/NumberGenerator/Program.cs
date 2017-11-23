using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            int number = 0;

            for (int first = m; first >= 1; first--)
            {
                for (int second = n; second >= 1; second--)
                {
                    for (int third = l; third >= 1; third--)
                    {
                        number = int.Parse($"{first}{second}{third}");

                        if (number % 3 == 0) special += 5;
                        else if (number % 10 == 5) special -= 2;
                        else if (number % 2 == 0) special *= 2;

                        if (special >= control) break;    
                    }
                    if (special >= control) break;
                }
                if (special >= control) break;
            }

            if (special >= control) Console.WriteLine($"Yes! Control number was reached! Current special number is {special}.");
            else if (special < control) Console.WriteLine($"No! {special} is the last reached special number.");

        }
    }
}
