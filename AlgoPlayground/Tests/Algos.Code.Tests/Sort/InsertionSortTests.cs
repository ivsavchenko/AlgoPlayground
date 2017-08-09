using System;
using System.Linq;
using Algos.Code.Sort;
using Algos.Code.Tests.Extensions;
using Xunit;

namespace Algos.Code.Tests.Sort
{
    public class InsertionSortTests
    {
        [Fact]
        public void Should_Return_Sorted_Array()
        {            
            Random r = new Random();
            int[] input = r.GenerateIntArray(113).ToArray();

            InsertionSort sort = new InsertionSort();
            var actual = sort.Sort(input);

            Assert.True(actual.IsSorted());    
            
        }

        [Fact]
        public void Should_Return_Sorted_Array_WithoutWhile()
        {
            Random r = new Random();
            int[] input = r.GenerateIntArray(113).ToArray();

            InsertionSort sort = new InsertionSort();
            var actual = sort.SortWithoutWhile(input);

            Assert.True(actual.IsSorted());
        }
    }
}
