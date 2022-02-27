using RecordTypeTest;
using System;
using Xunit;

namespace TheRecordTypeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var instance1 = new RecordType();
            var instance2 = new RecordType();
            Assert.Equal(instance1, instance2);
            
        }
    }
}
