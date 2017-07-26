using Algos.Code.Recursion;
using Xunit;

namespace Algos.Code.Tests.Recursion
{
    public class FibonacciRecursiveTests
    {
        [Fact]
        public void Should_Return_832040()
        {
            int expected = 832040;
            FibonacciRecursive fib = new FibonacciRecursive();
            var actual = fib.CalculateFromNto1(30);

            Assert.Equal(expected, actual);
        }
    }
}
