using Algos.Code.Recursion;
using Xunit;

namespace Algos.Code.Tests.Recursion
{
    public class FibonacciTailRecursiveTests
    {
        [Fact]
        public void Should_Return_832040()
        {
            int expected = 832040;
            FibonacciTailRecursive fib = new FibonacciTailRecursive();
            var actual = fib.Calculate(30);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_1()
        {
            int expected = 1;
            FibonacciTailRecursive fib = new FibonacciTailRecursive();
            var actual = fib.Calculate(1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_0()
        {
            int expected = 0;
            FibonacciTailRecursive fib = new FibonacciTailRecursive();
            var actual = fib.Calculate(0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_8()
        {
            int expected = 8;
            FibonacciTailRecursive fib = new FibonacciTailRecursive();
            var actual = fib.Calculate(6);

            Assert.Equal(expected, actual);
        }
    }
}
