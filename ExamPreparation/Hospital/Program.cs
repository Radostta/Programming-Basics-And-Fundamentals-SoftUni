using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double doctors = 7;
            double treated = 0;
            double untreated = 0;

            for (int day = 1; day <= days; day++)
            {
                if (day % 3 == 0 && untreated > treated)
                {
                    doctors++;
                }

                double patients = double.Parse(Console.ReadLine());

                if (patients > doctors)
                {
                    treated += doctors;
                    untreated += (patients - doctors);
                }
                else
                {
                    treated += patients;
                }                                                                      
            }

            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
