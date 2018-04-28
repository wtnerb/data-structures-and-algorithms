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
            t.Add(5, 5);
            t.Add(5, 6);
            t.Add(5, 4);

            //Act
            IEnumerable<Node<byte>> result = Program.FindMatches(t, target);

            //Assert
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(4, 3)]
        [InlineData(14, 1)]//finds root
        [InlineData(16, 2)]
        public void DoesFindCorrectNumberOfMatches(byte target, byte expected)
        {
            //Arrange
            byte[] arr = new byte[] { 11, 5, 13, 16, 17 };
            Node<byte> n = new Node<byte>(14, arr);
            Tree<byte> t = new Tree<byte>(n);
            t.Add(5, 15);
            t.Add(5, 16);
            t.Add(5, 4);
            t.Add(15, 4);
            t.Add(17, 4);

            //Act
            List<Node<byte>> result = Program.FindMatches(t, target);

            //Assert
            Assert.Equal(expected, result.Count);
        }
    }
}
