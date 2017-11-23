using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputMoney = decimal.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine().ToLower();
            var outputCurrency = Console.ReadLine().ToLower();

            var levaMoney = 0.0m;
            var outputMoney = 0.0m;

            if (inputCurrency == "bgn")
            {
                levaMoney = inputMoney; 
            }
            else if (inputCurrency == "usd")
            {
                levaMoney = inputMoney * 1.79549m;
            }
            else if (inputCurrency == "eur")
            {
                levaMoney = inputMoney * 1.95583m;
            }
            else if (inputCurrency == "gbp")
            {
                levaMoney = inputMoney * 2.53405m;
            }

            if (outputCurrency == "bgn")
            {
                outputMoney = levaMoney; 
            }
            else if (outputCurrency == "usd")
            {
                outputMoney = levaMoney / 1.79549m;
            }
            else if (outputCurrency == "eur")
            {
                outputMoney = levaMoney / 1.95583m;
            }
            else if (outputCurrency == "gbp")
            {
                outputMoney = levaMoney / 2.53405m;
            }

            //outputCurrency = outputCurrency.ToUpper();

            Console.WriteLine($"{outputMoney:f2} {outputCurrency.ToUpper()}");

            //   double value = double.Parse(Console.ReadLine());
            //   string inputValue = Console.ReadLine();
            //   string outputValue = Console.ReadLine();
            //
            //   double money = 0;
            //
            //   if (inputValue == "USD")
            //   {
            //       money = value * 1.79549;
            //   }
            //
            //   else if (inputValue == "EUR")
            //   {
            //       money = value * 1.95583;
            //   }
            //
            //   else if (inputValue == "GBP")
            //   {
            //       money = value * 2.53405;
            //   }
            //
            //   else
            //
            //   {
            //       money = value;
            //   }
            //
            //   if (outputValue == "USD")
            //   {
            //       money = money / 1.79549;
            //
            //   }
            //
            //   else if (outputValue == "EUR")
            //   {
            //       money = money / 1.95583;
            //
            //   }
            //
            //   else if (outputValue == "GBP")
            //   {
            //       money = money / 2.53405;
            //   }
            //
            //   Console.WriteLine($"{money:f2} {outputValue}");
        }
    }
}
