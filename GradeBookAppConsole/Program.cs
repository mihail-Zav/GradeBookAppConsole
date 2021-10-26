using System;
using System.Collections.Generic;

namespace GradeBookAppConsole
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("Bob's book");
            book1.AddGrade(16.5);
            book1.AddGrade(34.9);
            book1.AddGrade(20.6);
            book1.AddGrade(56.5);
            book1.AddGrade(10.8);
            var stats = book1.GetStats();
            Console.WriteLine($"The stats for this grade bokk are as follows: " +
                $"\n Lowest grade: {stats.Low} \n Highest grade: {stats.High} \n Average grade: {stats.Average:N1}");
            /*
            double[] arr1 = new double[3];
            List<double> grades = new List<double>() { 1, 2, 3.4, 5.6, 6 };
            grades.Add(2.34);
            var numbers = new[] { 1, 2, 3.4, 5.6, 6 };
            arr1[0] = 1.2;
            arr1[1] = 2.4;
            arr1[2] = 3.5;
            var res = 0.0;
            foreach(var num in grades)
            {
                res += num;
            }
            res /= grades.Count;
            Console.WriteLine($"hi {res:N1}"); 
            */
            //Console.WriteLine($"Hello {args[0]}!");
        }
    }
}
