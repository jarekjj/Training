using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            var x = 5;
            var y = 2;
            var expected = 10;
            var actual = x * y;

            Assert.Equal(expected, actual);
        }
    }
}
