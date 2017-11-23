using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades_WithFiles
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double AverageGrades
        {
            get {return Grades.Average();}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string dNframeworkInputPath = @"..\..\Inputs.txt";
            string[] lines = File.ReadAllLines(dNframeworkInputPath);

            string result = "";

            for (int index = 0; index < lines.Length; index++)
            {
                int studentsCount = int.Parse(lines[index]);

                List<Student> students = new List<Student>();

                while (studentsCount-- > 0)
                {
                    var line = lines[index + 1].Split();

                    string Name = line[0];
                    var grades = line.Skip(1).Select(double.Parse).ToArray();

                    Student student = new Student();
                    student.Name = Name;
                    student.Grades = grades;

                    students.Add(student);
                    index++;
                }

                students = students
                    .Where(s => s.AverageGrades >= 5.00)
                    .OrderBy(s => s.Name)
                    .ThenByDescending(s => s.AverageGrades)
                    .ToList();

                foreach (var s in students)
                {
                    result += $"{s.Name} -> {s.AverageGrades:F2}" + Environment.NewLine;
                }
                result += Environment.NewLine;
            }

            string dNframeworkOutputPath = @"..\..\Outputs.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}

