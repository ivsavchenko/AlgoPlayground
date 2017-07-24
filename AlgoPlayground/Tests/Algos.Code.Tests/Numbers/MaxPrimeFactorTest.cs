﻿using Algos.Code.Numbers;
using Xunit;

namespace Algos.Code.Tests.Numbers
{
    public class MaxPrimeFactorTest
    {
        [Fact]
        public void Should_Return_MaxFactor()
        {
            long input = 600851475143;
            long expected = 6857;

            MaxPrimeFactor max = new MaxPrimeFactor();
            long actual = max.Calculate(input);

            Assert.Equal(expected, actual);
        }
    }
}