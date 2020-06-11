
using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateAnAverageGrade()
        {
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.GetStatistics();

            Assert.Equal(85.633, result.average,3);
            Assert.Equal(90.5, result.high);
            Assert.Equal(77.3, result.low);
            Assert.Equal('B', result.letter);

        }
       

        

       
       
        
    }
}
