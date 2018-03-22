using System;
using Xunit;
using Program;

namespace Binary_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(-1, Program.BinarySearch())
        }
    }
}
