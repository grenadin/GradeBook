using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine($"Hi, This is GradeBook Program.");
            Console.WriteLine($"Please input you name and your score");
            Console.Write($"Please input your name =>");
            var book = new Book();
            book.name = Console.ReadLine();
            var done = false;
            while (true)
            {
                Console.Write($"Please input your score or input 'q' to quit =>");
                var input = Console.ReadLine();
                if (input == "q")
                {

                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                
            }
            
            //book.AddGrade(Convert.ToDouble(Console.ReadLine()));

            var stats = book.GetStatistics();
            Console.WriteLine($"This is {book.name}'s Gradebook");
            Console.WriteLine($"The Average grade is {stats.average:N2}");
            Console.WriteLine($"The Lowest grade is {stats.low}");
            Console.WriteLine($"The Highest grade is {stats.high}");
            Console.WriteLine($"The letter grade is {stats.letter}");

           


        }

       

       



    } 
       
}

