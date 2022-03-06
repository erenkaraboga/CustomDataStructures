using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Generic
{
    public class Array<T> : IEnumerable
         where T : new()
    {
        private T[] InnerList;
        private int index;
        public Array(int size = 16)
        {
            InnerList = new T[16];
            index = 0;
        }
        public Array(params T[] collection)
        {
            InnerList = new T[collection.Length];
            index = 0;
            foreach (var item in collection)
            {
                InnerList[index] = item;
                index++;

            }
        }

        public IEnumerator GetEnumerator()
        {
            return InnerList.Take(index).GetEnumerator();
        }
    }
}

