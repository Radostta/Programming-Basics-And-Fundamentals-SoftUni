using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int workingHours = days * 8 * workers;
            int hoursDifference = Math.Abs(workingHours - hoursNeeded);
            int penalties = hoursDifference * days;

            if (hoursNeeded > workingHours)
            {
                Console.WriteLine($"{hoursDifference} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
            else
            {
                Console.WriteLine($"{hoursDifference} hours left");
            }
        }
    }
}
