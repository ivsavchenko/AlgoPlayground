using Algos.Code.Dynamic;
using Xunit;

namespace Algos.Code.Tests.Dynamic
{
    public class FibonacciDynamicTests
    {
        [Fact]
        public void Should_Return_832040_From_Array()
        {
            int expected = 832040;
            FibonacciDynamic fib = new FibonacciDynamic();
            var actual = fib.Calculate(30);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_832040_From_Memo()
        {
            int expected = 832040;
            FibonacciWithMemo fib = new FibonacciWithMemo();
            var actual = fib.Calculate(30);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_1_From_Array()
        {
            int expected = 1;
            FibonacciDynamic fib = new FibonacciDynamic();
            var actual = fib.Calculate(1);

            Assert.Equal(expected, actual);
        }
    }
}
