using System.Collections;
using System;
namespace DataStructures.Array
{
    public class CustomEnumarateClass : IEnumerator
    {
        private Object[] InnerList;
        private int Index;
        public object Current => InnerList[Index];

        public CustomEnumarateClass(Object[] arr)
        {
            InnerList = arr;
            Index = InnerList.Length;


        }
        public bool MoveNext()
        {
            if (Index == InnerList.Length)
            {

                Index = InnerList.Length - 1;
                return true;
            }
            if (Index > 0)
            {
                Index--;
                return true;
            }
            else
            {
                Index = InnerList.Length;
                return false;
            }

        }

        public void Reset()
        {
            Index = InnerList.Length;
        }
    }

}