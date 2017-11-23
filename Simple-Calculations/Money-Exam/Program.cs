using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var com = double.Parse(Console.ReadLine()) / 100;

            var bitToLeva = bitcoin * 1168;
            var yuanToLeva = yuan * (0.15 * 1.76);
            var levaSum = bitToLeva + yuanToLeva;
            var euro = levaSum / 1.95;
            var money = euro - (com * euro);

            Console.WriteLine(money);
        }
    }
}
