using System;
using Xunit;
using static repeated_word.Program;
using Hash_Table;

namespace TestingWords
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("blue", 1)]
        [InlineData("cat", 2)]
        [InlineData("act", 4)]
        public void CanLoadTable(string key, int value)
        {
            //Act
            string text = "blue green white yellow cat act tac cta tac act act green cat act";
            HashTable table = LoadHashTable(text);

            //Arrange
            int hash = table.Hash(key);
            Node current = table.Map[hash];
            while (current.Key != key && current != null)
            {
                current = current.Next;
            }
            if (current == null)
            {
                throw new Exception();
            }

            //Assert
            Assert.Equal(key, current.Key);
            Assert.Equal(value, current.Value);
        }
    }
}
