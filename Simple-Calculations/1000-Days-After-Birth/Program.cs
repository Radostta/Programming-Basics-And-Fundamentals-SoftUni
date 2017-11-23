using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            // ERROR
            // var input = Console.ReadLine();
            // var date = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // date = date.AddDays(999);

            // var formatDate = date.ToString("dd-MM-yyyy");
            // Console.WriteLine(formatDate);

            //CORRECT
            //string ftm = "dd-MM-yyyy";
            //string value = Console.ReadLine();
            //DateTime userBirthday = DateTime.ParseExact(value, ftm, null);
            //Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));

            string dateString = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime output = Convert.ToDateTime(result).AddDays(999);
            Console.WriteLine(output.ToString("dd-MM-yyyy"));

        }
    }
}
