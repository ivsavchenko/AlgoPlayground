using Algos.Code.Arrays;
using Xunit;

namespace Algos.Code.Tests.Arrays
{
    public class MaxRepeatingElementTest
    {
        [Fact]
        public void Should_Return_5()
        {
            int expectedValue = 5;
            int expectedCount = 3;

            int[] input = { 4, 1, 5, 2, 1, 5, 9, 8, 6, 5, 3, 2, 4, 7 };
            MaxRepeatingElement algo = new MaxRepeatingElement();

            var actualValue = algo.Calculate(input);

            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedCount, input[actualValue] / input.Length);
        }
    }
}
