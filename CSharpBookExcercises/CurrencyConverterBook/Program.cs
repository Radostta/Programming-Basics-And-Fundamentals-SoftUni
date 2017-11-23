using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputAmount = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();

            double outputAmount = 0;

            if (inputCurrency == "USD")
            {
                outputAmount = inputAmount * 1.79549;
            }
            else if (inputCurrency == "EUR")
            {
                outputAmount = inputAmount * 1.95583;
            }
            else if (inputCurrency == "GBP")
            {
                outputAmount = inputAmount * 2.53405;
            }
            else
            {
                outputAmount = inputAmount;
            }

            if (outputCurrency == "USD")
            {
                outputAmount = outputAmount / 1.79549;
            }
            else if (outputCurrency == "EUR")
            {
                outputAmount = outputAmount / 1.95583;
            }
            else if (outputCurrency == "GBP")
            {
                outputAmount = outputAmount / 2.53405;
            }

            Console.WriteLine($"{outputValue,2} {outputCurrency}");
            
        }
    }
}
