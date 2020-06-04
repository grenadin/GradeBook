using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> _grades;
        private string _name;

        public Book()
        {
            _grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            _grades.Add(grade);
            
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.average = 0.0;
            result.high = double.MinValue;
            result.low = double.MaxValue;
            foreach (var grade in _grades)
            {
                Console.WriteLine($"The number that input into function AddGrade({grade})");
                result.low = Math.Min(grade, result.low);
                result.high = Math.Max(grade, result.high);
                result.average += grade;
            }
            result.average /= _grades.Count;
            Console.WriteLine();
            return result;
        }
    }
}