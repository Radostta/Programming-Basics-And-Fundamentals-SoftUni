using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //int period = int.Parse(Console.ReadLine());

            //int treatedPatients = 0;
            //int untreatedPatients = 0;
            //int countOfDoctors = 7;

            //for (int day = 1; day <= period; day++)
            //{
            //    var currentPatients = int.Parse(Console.ReadLine());

            //    if ((day % 3 == 0) && (untreatedPatients > treatedPatients))
            //    {
            //        countOfDoctors++;
            //    }

            //    if (currentPatients > countOfDoctors)
            //    {
            //        treatedPatients += countOfDoctors;
            //        untreatedPatients += currentPatients - countOfDoctors;
            //    }
            //    else
            //    {
            //        treatedPatients += currentPatients;
            //    }
            //}

            //Console.WriteLine(&"Treated patients: {treatedPatients}.");
            //Console.WriteLine(&"Untreated patients: {untreatedPatients}.");


            int nDays = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int numberDoctors = 7;

            for (int currentDay = 1; currentDay <= nDays; currentDay++)
            {
                int numberPatients = int.Parse(Console.ReadLine());

                if ((currentDay % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    numberDoctors++;
                }

                if (numberPatients > numberDoctors)
                {
                    untreatedPatients += (numberPatients - numberDoctors);
                    treatedPatients += numberDoctors;
                }
                else
                {
                    treatedPatients += numberPatients;

                }
            }

            Console.WriteLine("Treated patients: " + treatedPatients + '.');
            Console.WriteLine("Untreated patients: " + untreatedPatients + '.');
        }
    }
}
