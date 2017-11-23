using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCommision_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commission = -1.0;

            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500) commission = 0.05;
                else if (500 < sales && sales <= 1000) commission = 0.07;
                else if (1000 < sales && sales <= 10000) commission = 0.08;
                else if (sales > 10000) commission = 0.12;
            }
            else if (town == "varna")
            {
                if (0.0 <= sales && sales <= 500.0) commission = 0.045;
                else if (500 < sales && sales <= 1000) commission = 0.075;
                else if (1000 < sales && sales <= 10000) commission = 0.10;
                else if (sales > 10000) commission = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (0.0 <= sales && sales <= 500.0) commission = 0.055;
                else if (500 < sales && sales <= 1000) commission = 0.08;
                else if (1000 < sales && sales <= 10000) commission = 0.12;
                else if (sales > 10000) commission = 0.145;
            }

            if (commission >= 0)
            {
                Console.WriteLine("{0:f2}", sales * commission);
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
