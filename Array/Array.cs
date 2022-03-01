using System;

namespace DataStructures.Array
{
    public class Array:ICloneable
    {
        public int Lenghth => innerArray.Length;
        private Object[] innerArray { get; set; }
        public Array(int defaultSize=16)
        {
            innerArray = new Object[defaultSize];
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
    }
}
