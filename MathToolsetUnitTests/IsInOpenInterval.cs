using Xunit;
using Topology;

namespace ExtensionsUnitTests
{
    public class IsInOpenInterval
    {
        [Fact]
        public void IsFiveInTwoToFive()
        {

            bool result = 5.IsInOpenInterval(1, 5);

            Assert.False(result);
        }

        [Fact]
        public void IsSixInTwoToSix()
        {

            bool result = 6.IsInOpenInterval(2, 6);

            Assert.False(result);
        }


        [Fact]
        public void IsZeroInTwoToFive()
        {

            bool result = 0.IsInOpenInterval(1, 5);

            Assert.False(result);
        }

        [Fact]
        public void IsFourtyInTenToFivehundred()
        {

            bool result = 40.IsInOpenInterval(10, 500);

            Assert.True(result);
        }
    }
}
