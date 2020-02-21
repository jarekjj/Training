using System;
using Xunit;

namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTest
    {
        
        [Fact]
        public void WriteLogDelegateCanPointMethod()
        {
            WriteLogDelegate log;

            log = ReturnMessage;

            var result = log("Hello");
            Assert.Equal("Hello", result);
        }

        string ReturnMessage(string message)
        {
            return message;
        }


        [Fact]
        public void CanSetNameFromReference()
        {
        var book1 = GetBook("Book 1");
        SetName(book1, "New name");

        Assert.Equal("Book 1", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        
        [Fact]
        public void GetBookReturnDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwoVarsCanRefSameObj()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
