using Algos.Code.Arrays;
using Xunit;

namespace Algos.Code.Tests.Arrays
{
    public class SumDivAndConqTests
    { 
        [Fact]
        public void Should_Return_33()
        {
            int[] input = new int[] { 2, 15, 3, 6, 7 };
            int expected = 33;

            SumDivAndConq algo = new SumDivAndConq();
            var actual = algo.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_17()
        {
            int expected = 17;
            int[] input = new int[] { expected };            

            SumDivAndConq algo = new SumDivAndConq();
            var actual = algo.Calculate(input);

            Assert.Equal(expected, actual);
        }
    }
}
