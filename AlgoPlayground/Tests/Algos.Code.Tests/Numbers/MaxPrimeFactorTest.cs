using Algos.Code.Numbers;
using Xunit;

namespace Algos.Code.Tests.Numbers
{
    public class MaxPrimeFactorTest
    {
        [Fact]
        public void Should_Brute_MaxFactor()
        {
            long input = 600851475143;
            long expected = 6857;

            MaxPrimeFactor max = new MaxPrimeFactor();
            long actual = max.CalculateBrute(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_MaxFactor()
        {
            long input = 600851475143;
            long expected = 6857;

            MaxPrimeFactor max = new MaxPrimeFactor();
            long actual = max.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_MaxFactor_Small_Sqrt()
        {
            long input = 14;
            long expected = 7;

            MaxPrimeFactor max = new MaxPrimeFactor();
            long actual = max.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_MaxFactor_For_2()
        {
            long input = 2;
            long expected = 2;

            MaxPrimeFactor max = new MaxPrimeFactor();
            long actual = max.Calculate(input);

            Assert.Equal(expected, actual);
        }
    }
}
