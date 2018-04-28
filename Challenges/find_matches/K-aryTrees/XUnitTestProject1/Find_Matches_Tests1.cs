using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using K_aryTrees;

namespace XUnitTestProject1
{
    public class Find_Matches_Tests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(15)]
        [InlineData(7)]
        public void DoesNotFindFalseMatch(byte target)
        {
            //Arrange
            byte[] arr = new byte[] { 11, 5, 13, 16, 17 };
            Node<byte> n = new Node<byte>(14, arr);
            Tree<byte> t = new Tree<byte>(n);
            t.Add(5, 5); // can add
            t.Add(5, 6); // will add to correct duplicate
            t.Add(5, 4); // will add to end of child list

            //Act
            IEnumerable<Node<byte>> result = Program.FindMatches(t, target);
        }
    }
}
