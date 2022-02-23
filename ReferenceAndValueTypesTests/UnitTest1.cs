using System;
using System.Collections.Generic;
using Xunit;

namespace ReferenceAndValueTypesTests
{
    public class RefAndValueTypeTests
    {
        [Fact]
        public void check_reference_type_test()
        {
            var p1 = new ValueAndReferenceTypes.ReferenceType(3, 4);
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
    }
}
