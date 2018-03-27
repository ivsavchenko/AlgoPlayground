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

        [Fact]
        public void Should_Return_1()
        {
            int expected = 1;
            FibonacciRecursive fib = new FibonacciRecursive();
            var actual = fib.CalculateFromNto1(1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_0()
        {
            int expected = 0;
            FibonacciRecursive fib = new FibonacciRecursive();
            var actual = fib.CalculateFromNto1(0);

            Assert.Equal(expected, actual);
        }
    }
}
