using Algos.Code.DataStructures.LinkedList;
using System;
using Xunit;

namespace Algos.Code.Tests.DataStructures.LinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void Should_Have_Exact_Inserted_Items_1()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.Equal(list[0], 1);
            Assert.Equal(list[1], 2);
            Assert.Equal(list[2], 3);
        }

        [Fact]
        public void Should_Have_Exact_Inserted_Items_2()
        {
            LinkedList<int> list = new LinkedList<int>();            

            list.Insert(0, 10);
            list.Add(77);
            list.Insert(1, 555);

            Assert.Equal(list[0], 10);
            Assert.Equal(list[1], 555);
            Assert.Equal(list[2], 77);
        }

        [Fact]
        public void Should_Throw_Exception()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Delete(0);
            list.Delete(0);
            list.Delete(0);

            Assert.Throws<IndexOutOfRangeException>(() => { var t = list[0]; });
        }
    }
}
