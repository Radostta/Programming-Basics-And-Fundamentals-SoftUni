using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades_Original
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double AverageGrades
        {
            get
            {
                return Grades.Average();
            }
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List <Student> students = new List<Student>();

            while (studentsCount-- > 0) // same as studentsCount--; inside the body
            {
                var line = Console.ReadLine().Split();

                string Name = line[0];
                var grades = line.Skip(1).Select(double.Parse).ToArray();

                Student student = new Student();
                student.Name = Name;
                student.Grades = grades;

                students.Add(student);
            }

            //Print: only >= 5.00, ordered by name, then by average grades

            students = students
                .Where(s => s.AverageGrades >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrades)
                .ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} -> {s.AverageGrades:F2}");
            }
            
        }
    }
}
