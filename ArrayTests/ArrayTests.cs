using System;
using Xunit;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]
        public void ArraySetValueTest()
        {
            var arr = new DataStructures.Array.Array();
            arr.SetValue(10,0);
            Assert.Equal(10, arr.GetValue(0));
        }
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]

        public void CheckDefaultSizeFuture(int defaultSize)
        {
            var arr = new DataStructures.Array.Array(defaultSize);

            Assert.Equal(defaultSize, arr.Lenghth);

        }
        [Fact]
        public void CheckClonableTest()
        {
            var arr = new DataStructures.Array.Array();
            arr.SetValue(1, 0);
            arr.SetValue(2, 0);
            arr.SetValue(3, 0);
            arr.SetValue(4, 0);
            var clonedArr = arr.Clone() as DataStructures.Array.Array;
            Assert.IsType<DataStructures.Array.Array>(clonedArr);
        } 
    }
}
