using Array.Generic;
using System;
using System.Collections.Generic;

namespace RefAndOutConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var arr = new Array<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            /*var refType = new ValueAndReferenceTypes.ReferenceType();
            var valueType = new ValueAndReferenceTypes.ValueType();
            int a = 23,b = 55;
            valueType.swap(a, b);
            Console.WriteLine("{0}-{1}",a,b);
            refType.SwapRefValue(ref a, ref b);
            Console.WriteLine("{0}-{1}", a, b);

            refType.CheckOutKeyWordByValue(b);
            Console.WriteLine(b);
            refType.CheckOutKeyWordByRef(out b);
            Console.WriteLine(b);*/
        }
    }
}
