using Algos.Code.Sort;
using Algos.Code.Tests.Extensions;
using System;
using System.Linq;
using Xunit;

namespace Algos.Code.Tests.Sort
{
    public class MergeSortTests
    {
        [Fact]
        public void Should_Return_Sorted_Array()
        {
            Random r = new Random();
            int[] input = r.GenerateIntArray(113).ToArray();

            MergeSort sort = new MergeSort();
            int[] output = sort.Sort(input);

            Assert.True(output.IsSorted());
        }
    }
}
