using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using Xunit;


namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void Test2()
        {

            var book1 = GetBook("a");
            var book2 = GetBook("a");

            Assert.Same(book1.name, book2.name);
            //GetBookSetName(book1, "New Name");
            //Assert.Equal(book1, book2);

            //var book2 = GetBook("Book 1");
            //book2 = book1;
            //Assert.Same(book1, book2);
            //Assert.NotSame(book1, book2);

            //Assert.True(object.ReferenceEquals(book1,book2));
         
        }

        [Fact]
        public void StringsBehehaveLikeValueTypes()
        {
            string name = "Harirak";
            MakeUppercase(name);
            Assert.Equal("HARIRAK", name);
        }

        private void MakeUppercase(string name)
        {
           name.ToUpper();
        }

        void GetBookSetName(Book book, string name)
        {
            //book = new Book(name);
            book.name = name;
        }

        void SetName(Book book, string name)
        {
            book.name = name;
        }



        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
