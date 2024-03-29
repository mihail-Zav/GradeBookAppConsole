using System;
using Xunit;

namespace GradeBookAppConsole.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }

        [Fact]
        public void TwoVarsReferenceOneObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;
            book2.Name = "Book 2";

            Assert.Equal("Book 2", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2)); // Does the same as the above line
        }

        [Fact]
        public void PassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void PassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameWithRef(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameWithRef(ref Book book, string name)
        {
            book = new Book(name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
