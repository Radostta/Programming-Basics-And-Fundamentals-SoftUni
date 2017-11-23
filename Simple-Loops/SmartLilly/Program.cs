using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var n = int.Parse(Console.ReadLine()); //Lilly's age
            double wMachinePrice = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());

            double MoneyPerBirthday = 10.0;
            double numberToys = 0.0;
            double moneySaved = 0.0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += (MoneyPerBirthday - 1);
                    MoneyPerBirthday += 10;
                }
                else
                {
                    numberToys++;
                }
            }

            moneySaved += (numberToys * pricePerToy);

            if (wMachinePrice <= moneySaved)
            {
                Console.WriteLine($"Yes! {(moneySaved - wMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(wMachinePrice - moneySaved):f2}");
            }



            
            
        }
    }
}
