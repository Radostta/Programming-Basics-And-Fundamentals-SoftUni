using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());

            var inputValue = Console.ReadLine();
            var outputValue = Console.ReadLine();

            var value = 0.0;

            if (inputValue == "USD")
            {
                value = money * 1.79549;
            }
            else if (inputValue == "EUR")
            {
                value = money * 1.95583;
            }
            else if (inputValue == "GBP")
            {
                value = money * 2.53405;
            }
            else
            {
                value = money;
            }

            if (outputValue == "USD")
            {
                value = value / 1.79549;
            }
            else if (outputValue == "EUR")
            {
                value = value / 1.95583;
            }
            else if (outputValue == "GBP")
            {
                value = value / 2.53405;
                // value /= 2.53405;
            }
            Console.WriteLine($"{value:f2} {outputValue}");

        }
    }
}
