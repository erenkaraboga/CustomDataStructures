using System.Collections;
using System;
namespace DataStructures.Array
{
    public class CustomEnumarateClass : IEnumerator
    {
        private Object[] _array;
        private int Index = -1;
        public object Current => _array[Index];

        public CustomEnumarateClass(Object[] arr)
        {
            _array = arr;
         
        }
        public bool MoveNext()
        {
            if (Index < _array.Length-1)
            {

                Index++;
                return true;
            }
            return false;

        }

        public void Reset()
        {
            Index = -1;
        }
    }

}