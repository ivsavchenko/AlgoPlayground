using Algos.Code.Sort;
using Algos.Code.Tests.Extensions;
using System;
using System.Linq;
using Xunit;

namespace Algos.Code.Tests.Sort
{
    public class ShellSortTests
    {
        [Fact]
        public void Should_Return_Sorted_Array()
        {
            Random r = new Random();
            int[] input = r.GenerateIntArray(113).ToArray();

            ShellSort sort = new ShellSort();
            var actual = sort.Sort(input);

            Assert.True(actual.IsSorted());
        }

        [Fact]
        public void Should_Be_Much_Faster_Than_Insertion()
        {
            Random r = new Random();
            int[] inputInsertions = r.GenerateIntArray(7000).ToArray();
            int[] inputShell = (int[])inputInsertions.Clone();

            ShellSort shell = new ShellSort();
            var actualShell = shell.Sort(inputShell);

            InsertionSort inserts = new InsertionSort();
            var actualInserts = inserts.Sort(inputInsertions);

            Assert.True(actualShell.IsSorted());
            Assert.True(actualInserts.IsSorted());

            Assert.True(inserts.Counter > shell.Counter);
        }
    }
}
