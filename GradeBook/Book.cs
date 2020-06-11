using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace GradeBook
{
    public class Book
    {
        private List<double> _grades;
        public string name;
        
        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'F':
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }
        

        public Book(string name)
        {
            _grades = new List<double>();
            this.name = name;
        }

        public Book()
        {
            _grades = new List<double>();
            

        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                    _grades.Add(grade);       
            }
            else
            {
                throw new ArgumentException($"{nameof(grade)}");
            }
                
            
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

            switch (result.average)
            {
                case var d when d >= 90.0:
                    result.letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.letter = 'D';
                    break;
                default:
                    result.letter = 'F';
                    break;
            }
            return result;
        }

        
    }
}