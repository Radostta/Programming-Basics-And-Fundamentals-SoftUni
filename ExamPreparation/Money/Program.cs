using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoinCount = double.Parse(Console.ReadLine());
            double yuanCount = double.Parse(Console.ReadLine());
            double commisionPercent = double.Parse(Console.ReadLine());

            double levaFromBitcoins = bitcoinCount * 1168;
            double levaFromYuans = yuanCount * 0.15 * 1.76;

            double euros = (levaFromBitcoins + levaFromYuans) / 1.95;
            euros -= euros * commisionPercent / 100;
            Console.WriteLine($"{euros:f2}");

        }
    }
}
