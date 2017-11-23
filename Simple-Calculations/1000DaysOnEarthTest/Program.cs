using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysOnEarthTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            string format = "dd-MM-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime result = DateTime.ParseExact(dateString, format, provider);
            DateTime output = Convert.ToDateTime(result).AddDays(999);
            Console.WriteLine(output.ToString("dd-MM-yyyy"));
        }
    }
}
