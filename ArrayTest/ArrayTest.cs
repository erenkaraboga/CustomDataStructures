using System;
using Xunit;

namespace ArrayTest
{
    public class ArrayTest
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)] 
        [InlineData(64)] 
        [InlineData(128)]
        [InlineData(256)]
        public void Check_Array_Constructor(int defaultSize)
        {
            var arr = new DataStructures.Array.Array(defaultSize);
            Assert.Equal(defaultSize, arr.Lenghth);
        }
        [Fact] 
        public void check_Array_Constructor_with_Params()
        {
            var arr = new DataStructures.Array.Array(1, 2, 3);
            Assert.Equal(3, arr.Lenghth);
        }
        [Fact]
        public void Get_and_SetValues()
        {
            var arr = new DataStructures.Array.Array();
            arr.SetValue(1, 0);
            arr.GetValue(0);
            Assert.Equal(1,arr.GetValue(0));
        }
        [Fact]
        public void checkClonable()
        {
            var arr= new DataStructures.Array.Array(1,2,3);
            var arr2 = arr.Clone() as DataStructures.Array.Array;
            Assert.Equal(arr.Lenghth, arr2.Lenghth);
            Assert.Equal(arr.GetHashCode(), arr2.GetHashCode());    
        }

    }
}
