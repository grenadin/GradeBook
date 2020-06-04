using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book();
            book.AddGrade(95.4);
            book.AddGrade(45.3);
            book.AddGrade(21.4);
            book.AddGrade(99.2);

            var stats = book.GetStatistics();

            Console.WriteLine($"The Average grade is {stats.average:N2}");
            Console.WriteLine($"The Lowest grade is {stats.low}");
            Console.WriteLine($"The Highest grade is {stats.high}");


        }
    }
}
