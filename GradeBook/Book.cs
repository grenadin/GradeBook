using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> _grades;

        public Book()
        {
            _grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            _grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            foreach (var number in _grades)
            {
                Console.WriteLine($"The number that input into function AddGrade({number})");
                lowestGrade = Math.Min(number, lowestGrade);
                highestGrade = Math.Max(number, highestGrade);
                result += number;
            }
            result /= _grades.Count;
            Console.WriteLine();
            Console.WriteLine($"The Average grade is {result:N2}");
            Console.WriteLine($"The Lowest grade is {lowestGrade}");
            Console.WriteLine($"The Highest grade is {highestGrade}");
        }
    }
}