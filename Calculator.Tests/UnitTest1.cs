using System;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_Test()
        {
            double actual = 8;
            var expected = Calculator.Add(6, 2);
            Assert.Equal(expected, actual);
        }
    }
}
