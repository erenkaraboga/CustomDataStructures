﻿using System;
using System.Collections;

namespace DataStructures.Array
{
    public class Array:ICloneable,IEnumerable
    {
        public int Lenghth => innerArray.Length;
        private Object[] innerArray { get; set; }
        public Array(int defaultSize=16)
        {
            innerArray = new Object[defaultSize];
        }
        public Array(params Object[] sourceArray):this(sourceArray.Length)
        {
           System.Array.Copy(sourceArray,innerArray,sourceArray.Length);
        }
        public void SetValue(Object value , int index)
        {
            if (!(index>=0 && index<innerArray.Length))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (value==null)
            {
                throw new ArgumentNullException();
            }
            innerArray[index] = value;
            return;
        }
        public Object GetValue(int index)
        {
            if (!(index >= 0 && index < innerArray.Length))
            {
                throw new ArgumentOutOfRangeException();
            }
            return innerArray[index];
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            return innerArray.GetEnumerator();
        }
    }
}
