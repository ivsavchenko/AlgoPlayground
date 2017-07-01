using Algos.Code.DataStructures.LinkedList;
using System;
using Xunit;

namespace Algos.Code.Tests.DataStructures.LinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void Test1()
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);

            ll.Delete(0);
            ll.Delete(0);
            ll.Delete(0);

            ll.Insert(0, 10);
            ll.Insert(0, 11);
            ll.Insert(0, 12);
            ll.Add(77);
            ll.Insert(2, 555);

            foreach (var item in ll)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
