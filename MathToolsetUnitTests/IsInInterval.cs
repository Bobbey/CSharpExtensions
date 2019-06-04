using System;
using Xunit;
using Topology;

namespace ExtensionsUnitTests
{
    public class IsInInterval
    {
        [Fact]
        public void IsFiveInTwoToFive()
        {

            bool result = 5.IsInInterval("[2,5]");

            Assert.True(result);
        }

        [Fact]
        public void IsFiveInTwoToFiveBottomOpen()
        {

            bool result = 5.IsInInterval("(2,5]");

            Assert.True(result);
        }

        [Fact]
        public void IsZeroInTwoToFiveBottomOpen()
        {

            bool result = 0.IsInInterval("(2,5]");

            Assert.False(result);
        }


        [Fact]
        public void IsHundredTwentyThreeInTwentyThreeToHundredTwentyThreeBottomOpen()
        {

            bool result = 123.IsInInterval("(23,123]");

            Assert.True(result);
        }


        [Fact]
        public void IsHundredTwentyThreeInTwentyThreeToHundredTwentyThreeOpen()
        {

            bool result = 123.IsInInterval("(23,123)");

            Assert.False(result);
        }


        [Fact]
        public void IsMinusOneInTwentyThreeToHundredTwentyThreeOpen()
        {

            bool result = (-1).IsInInterval("(23,123)");

            Assert.False(result);
        }


        [Fact]
        public void ThrowsException()
        {

            try
            {
                bool result = 10.IsInInterval("(123,32)");
            }
            catch (Exception e)
            {
                Assert.IsType<ArgumentException>(e);
            }
           
        }
    }
}
