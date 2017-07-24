using Algos.Code.Numbers;
using Xunit;

namespace Algos.Code.Tests.Numbers
{
    public class EuclideanAlgoTests
    {
        [Fact]
        public void Should_Be_15()
        {
            int expected = 3;
            int a = 27;
            int b = 60;

            EuclideanAlgo algo = new EuclideanAlgo();
            int actual = algo.Calculate(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Be_63()
        {
            int expected = 63;
            int a = 600851475;
            int b = 16847649;

            EuclideanAlgo algo = new EuclideanAlgo();
            int actual = algo.Calculate(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Be_1()
        {
            int expected = 1;
            int a = 21;
            int b = 6857;

            EuclideanAlgo algo = new EuclideanAlgo();
            int actual = algo.Calculate(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
