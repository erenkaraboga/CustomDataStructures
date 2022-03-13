using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayTest
{

    public class ArrayListTest
    {
        private ArrayList _arraylist;
        public ArrayListTest()
        {
            _arraylist = new ArrayList();
        }
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        public void ArrayListConsructorTest(int defaultSize)
        {
            var _arrayList = new ArrayList(defaultSize);
            Assert.Equal(_arrayList.Lenghth, defaultSize);

        }
        [Fact]
        public void ArrayListAddTest()
        {
            for (int i = 0; i < 20; i++)
            {
                _arraylist.Add(i);
            }
            Assert.Equal(32, _arraylist.Lenghth);
        }
        [Theory]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void ArrayListRemove(int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                _arraylist.Add(i);
            }
            Assert.Equal(lenght, _arraylist.Lenghth);
            for (int i = _arraylist.Lenghth - 1; i > 8; i--)
            {
                _arraylist.Remove();
            }
            Assert.Equal(32, _arraylist.Lenghth);
        }
        [Fact]
        public void ForEach_Test()
        {
            // arrange
            _arraylist.Add("a");
            _arraylist.Add("b");
            _arraylist.Add("c");
            _arraylist.Add("d");


            // act
            _arraylist.Remove();
            _arraylist.Remove();

            string s = "";
            foreach (var item in _arraylist)
            {
                s += item;
            }

            // assert
            Assert.Equal("ab", s);
        }
        [Fact]
        public void ArrayListConstructorWithIEnumarable()
        {
            var list = new List<int>() { 1, 2, 3 };
            var arr = new ArrayList(list);
            string s = "";
            foreach (var item in arr)
            {
                s += item;
            }
            Assert.Equal("123", s);
        }
        [Fact]
        public void IndexOf_Test()
        {
            // arrange 
            // a,b,c
            _arraylist.Add("a");
            _arraylist.Add("b");
            _arraylist.Add("c");

            // act
            var result = _arraylist.IndexOf("c");

            // Assert
            Assert.Equal(2, result);
        }
    }
}
