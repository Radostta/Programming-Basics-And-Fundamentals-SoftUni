using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                decimal centuries = decimal.Parse(Console.ReadLine());
                decimal years = centuries * 100m;
                decimal days = Math.Round(years * 365.2422m);
                decimal hours = days * 24m;
                decimal minutes = hours * 60m;
                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
            }            
        }
    }
}
