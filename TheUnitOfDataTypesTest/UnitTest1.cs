using System;
using Xunit;

namespace TheUnitOfDataTypesTest
{
    public class TheLimiOfDataTypesControlTest
    {
        [Fact]
        public void byte_data_type_control_tests()
        {
            //arrange 
            byte minValue,maxValue;
            //act 
            minValue = 0;
            maxValue = 255;
            //assert
            Assert.Equal(minValue, byte.MinValue);
            Assert.Equal(maxValue, byte.MaxValue);
        }
        [Fact]
        public void sbyte_data_type_control_tests()
        {
            //arrange 
            sbyte minValue, maxValue;
            //act 
            minValue = -128;
            maxValue = 127;
            //assert
            Assert.Equal(minValue, sbyte.MinValue);
            Assert.Equal(maxValue, sbyte.MaxValue);
        }
    }
}
