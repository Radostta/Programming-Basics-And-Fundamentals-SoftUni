using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime birthDay = DateTime.ParseExact(birthDate, format, null);
            
            DateTime after = birthDay.AddDays(999);

            Console.WriteLine(after.ToString("dd-MM-yyyy"));
        }
    }
}
