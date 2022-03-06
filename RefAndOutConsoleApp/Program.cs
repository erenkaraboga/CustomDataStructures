using System;
using System.Collections.Generic;

namespace RefAndOutConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            var refType = new ValueAndReferenceTypes.ReferenceType();
            var valueType = new ValueAndReferenceTypes.ValueType();
            int a = 23,b = 55;
            valueType.swap(a, b);
            Console.WriteLine("{0}-{1}",a,b);
            refType.SwapRefValue(ref a, ref b);
            Console.WriteLine("{0}-{1}", a, b);

            refType.CheckOutKeyWordByValue(b);
            Console.WriteLine(b);
            refType.CheckOutKeyWordByRef(out b);
            Console.WriteLine(b);
        }
    }
}
