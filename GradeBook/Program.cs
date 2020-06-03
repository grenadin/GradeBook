using System;

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
            book.ShowStatistics();
        }
    }
}
