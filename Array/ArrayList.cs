using DataStructures.Array;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayList : DataStructures.Array.Array,IEnumerable
    {
        private int position;
        public int Count => position;
        public ArrayList(int defaultSize = 2) : base(defaultSize)
        {
            position = 0;
        }
        public ArrayList(IEnumerable collection):this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public void Add(Object value)
        {
            if (position == Lenghth)
            {
                DoubleArray();
            }
            if (position < Lenghth)
            {
                innerArray[position] = value;
                position++;
                return;
            }
        }

        private void DoubleArray()
        {
            try
            {
                var temp = new Object[innerArray.Length * 2];
                System.Array.Copy(innerArray, temp, innerArray.Length);
                innerArray = temp;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Object Remove()
        {
            if (position >= 0)
            {
                var temp = innerArray[position - 1];
                position--;
                if (position == innerArray.Length / 4)
                    HalfArray();
                return temp;
            }
            throw new Exception();
        }

        private void HalfArray()
        {
            try
            {
                var temp = new Object[innerArray.Length / 2];
                System.Array.Copy(innerArray, temp, innerArray.Length / 2);
                innerArray = temp;
            }
            catch (Exception ex)
            {

            }
        }
       new  public IEnumerator GetEnumerator()
        {
            return innerArray.Take(position).GetEnumerator();
        }
    }
}