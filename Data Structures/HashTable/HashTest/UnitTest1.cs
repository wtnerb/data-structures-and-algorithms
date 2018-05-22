using System;
using Xunit;
using Hash_Table;

namespace HashTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanHash()
        {
            HashTable table = new HashTable();
            Assert.IsType<int>(table.Hash("this is a string"));
        }

        [Fact]
        public void HashesAreDistinct()
        {
            HashTable table = new HashTable();
            Assert.NotEqual(table.Hash("cat"), table.Hash("act"));
        }

        [Fact]
        public void CanAdd()
        {
            HashTable table = new HashTable();
            string test = "blue";
            int hash = table.Hash(test);
            table.Add(test, 47);
            table.Add(test, -32);
            Assert.Equal(47, table.Map[hash].Value);
            Assert.Equal(-32, table.Map[hash].Next.Value);
        }

        [Fact] void CanFind()
        {
            HashTable table = new HashTable();
            string test = "blue";
            table.Add(test, 43);
            Assert.True(table.Contains(test));
            Assert.False(table.Contains(test + "r"));
        }
    }
}
