using System;
using System.Collections.Generic;
using ValueAndReferenceTypes;
using Xunit;

namespace ReferenceAndValueTypesTests
{
    public class RefAndValueTypeTests
    {
        [Fact]
        public void check_reference_type_test()
        {
            var p1 = new ReferenceType(3, 4);
            var p2 = p1;
            p2.x = 10;
            Assert.Equal(p1.x, p2.x);
        
        }
        [Fact]
        public void check_value_type_test()
        {
            var p1 = new ValueAndReferenceTypes.ValueType(3, 4);
            var p2 = p1;
            p2.x = 10;
            Assert.NotEqual(p1.x, p2.x);

        }
        [Fact]
        public void record_type_Test()
        {
            var p1 = new RecordType(3, 4);
            var p2 = new RecordType(3, 5);
            Assert.Equal(p1, p2);
        }

        [Fact]
        public void check_list_type_test()
        {
            var list = new List<string>()
            {
                "Samsun",
                "Amasya",
                "Yozgat",
                "Sinop",
                "Bitlis",
                "Adana",
            };
            var list2 = new List<string>(list);
            list.Add("Istanbul");
            Assert.Equal(list.Count, list2.Count);
        }
        [Fact]
        public void swapvaluetest()
        {
            var valType = new ValueAndReferenceTypes.ValueType();
            int a = 23, b = 55;
            valType.swap(a, b);
            Assert.Equal(55, a);
            Assert.Equal(23, b);

        }
        [Fact]
        public void swapreftest()
        {
            var refType = new ValueAndReferenceTypes.ReferenceType();
            int a = 23, b = 55;
            refType.SwapRefValue(ref a,ref b);
            Assert.Equal(55, a);
            Assert.Equal(23, b);
        }
        [Fact]
        public void checkWithOut()
        {
            int x = 50;
            var refType = new ValueAndReferenceTypes.ReferenceType();
            refType.CheckOutKeyWordByRef(out x);
            Assert.Equal(100, x);
        }
        [Fact]
        public void checkWithNoOut()
        {
            int x = 50;
            var refType = new ValueAndReferenceTypes.ReferenceType();
            refType.CheckOutKeyWordByValue(x);
            Assert.Equal(100, x);
        }
    }
}
