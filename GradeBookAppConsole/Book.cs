using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBookAppConsole
{
    public class Book
    {
        List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            foreach(double grade in grades)
            {
                result.Low = Math.Min(result.Low, grade);
                result.High = Math.Max(result.High, grade);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
            //Console.WriteLine($"The stats for this grade bokk are as follows: " +
            //    $"\n Lowest grade: {low_grade} \n Highest grade: {high_grade} \n Average grade: {res}");
        }
    }
}
