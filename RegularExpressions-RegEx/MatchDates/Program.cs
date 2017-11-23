using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b(?<days>\d{2})([\/|\.|-])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");
            //var regex = new Regex(@"\b(?<days>\d{2})([\/|\.|-])(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})\b"); C# doesn't count named groups in back references

            var input = Console.ReadLine();

            var dates = regex.Matches(input);

            foreach (Match date in dates)
            {
                var day = date.Groups["days"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}
