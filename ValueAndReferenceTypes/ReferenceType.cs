using System;

namespace ValueAndReferenceTypes
{
    public class ReferenceType
    {
        public ReferenceType(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }
        public int y { get; set; }
       
    }
    public struct ValueType
    {
        public ValueType(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }
        public int y { get; set; }

    }
}
