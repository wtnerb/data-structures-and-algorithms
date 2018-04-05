using System;
using Xunit;
using multi_bracket_validation;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("for(")]
        [InlineData("for)")]
        [InlineData(")(for")]
        [InlineData("[}")]
        [InlineData("for(}")]
        [InlineData("for{[}]")]
        public void CanFailInvalid(string s)
        {
            Assert.False(Program.Magic(s));
        }

        [Theory]
        [InlineData("for")]
        [InlineData("for()")]
        [InlineData("(for)")]
        [InlineData("[{}]")]
        [InlineData("for({}[])")]
        public void CanPassValid(string s)
        {
            Assert.True(Program.Magic(s));
        }
    }
}
