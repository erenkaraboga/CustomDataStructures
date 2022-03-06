namespace ValueAndReferenceTypes
{
    public struct ValueType
    {
        public ValueType(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }
        public int y { get; set; }
        public void swap(int x, int y )
        {
            var temp = x;
            x = y;
            y = temp;

        }

    }
}
