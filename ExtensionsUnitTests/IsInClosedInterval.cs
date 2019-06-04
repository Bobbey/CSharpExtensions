using System;
using Xunit;
using Topology;

namespace ExtensionsUnitTests
{
    public class IsInClosedInterval
    {
        [Fact]
        public void IsFiveInTwoToFive()
        {

            bool result = 5.IsInClosedInterval(1, 5);

            Assert.True(result);
        }

        [Fact]
        public void IsZeroInTwoToFive()
        {

            bool result = 0.IsInClosedInterval(1, 5);

            Assert.False(result);
        }

        [Fact]
        public void IsFourtyInTenToFivehundred()
        {

            bool result = 40.IsInClosedInterval(10, 500);

            Assert.True(result);
        }
    }
}
