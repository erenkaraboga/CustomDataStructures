using ClassTypeTestt;
using System;
using Xunit;

namespace ClassTypeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var instance1 = new ClassType();
            instance1.X = 1;
            instance1.Y = 2;
            var instance2 = new ClassType();
            Assert.Equal(instance1, instance2);
        }
    }
}
