using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            var carCount = 0.0;
            var minibusCount = 0.0;
            var smallBusCount = 0.0;
            var bigBusCount = 0.0;
            var trainCount = 0.0;            

            for (int currentGroup = 1; currentGroup <= groupsCount; currentGroup++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    carCount += people;
                }
                else if (people <= 12)
                {
                    minibusCount += people;
                }
                else if (people <= 25)
                {
                    smallBusCount += people;
                }
                else if (people <= 40)
                {
                    bigBusCount += people;
                }
                else if (people >= 41)
                {
                    trainCount += people;
                }
            }

            var allPeople = carCount + minibusCount + smallBusCount + bigBusCount + trainCount;
            var carPercent = carCount / allPeople * 100.0;
            var minibusPercent = minibusCount / allPeople * 100.0;
            var smallBusPercent = smallBusCount / allPeople * 100.0;
            var bigBusPercent = bigBusCount / allPeople * 100.0;
            var trainPercent = trainCount / allPeople * 100.0;

            Console.WriteLine($"{carPercent:f2}%");
            Console.WriteLine($"{minibusPercent:f2}%");
            Console.WriteLine($"{smallBusPercent:f2}%");
            Console.WriteLine($"{bigBusPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
            
        }
    }
}
