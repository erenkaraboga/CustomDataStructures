using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    public record RecordType
    {
        public int x { get; set; }
        public int y { get; set; }

        public RecordType()
        {

        }
        public RecordType(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
