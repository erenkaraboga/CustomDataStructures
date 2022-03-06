using System;

namespace ValueAndReferenceTypes
{
    public class ReferenceType
    {
        public int x { get; set; }
        public int y { get; set; }

        public ReferenceType()
        {

        }
        public ReferenceType(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void SwapRefValue(ref int x, ref int  y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public void CheckOutKeyWordByRef(out int variable)
        {
            variable = 100;
            return;
        }
        public void CheckOutKeyWordByValue(int variable)
        {
            variable = 100;
            return;
        }

    }
}
