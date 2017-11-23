using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Refactor the following code:

            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0; int takova = 0; bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine($"{takova} -> {toe}");
            //    obshto = 0;
            //    ch = takova;
            //}

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digits = i;
                int sumDigits = 0;
                
                while (digits > 0)
                {
                    sumDigits += digits % 10;
                    digits = digits / 10;
                }
                bool isSpecial = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine($"{i} -> {isSpecial}");               
            }

        }
    }
}
