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
            Assert.NotEqual(table.Hash("cat"), table.Hash("acts"));
        }

        [Fact]
        public void CanAdd()
        {
            HashTable table = new HashTable();
            string test = "blue";
            int hash = table.Hash(test);
            table.Add(test, "test1");
            table.Add(test, "test2");
            Assert.Equal("test1", table.Map[hash].Value);
            Assert.Equal("test2", table.Map[hash].Next.Value);
        }

        [Fact] void CanFind()
        {
            HashTable table = new HashTable();
            string test = "blue";
            table.Add(test, "test1");
            Assert.True(table.Contains(test));
            Assert.False(table.Contains(test + "r"));
        }
    }
}
