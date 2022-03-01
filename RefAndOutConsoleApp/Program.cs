using System;
using System.Collections.Generic;

namespace RefAndOutConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[] { 1, 2, 3 };
            arr.SetValue(10 ,0);
            
            
            Console.WriteLine(arr.GetValue(0));
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



            /*var refAndValue = new ValueAndReferenceTypes.ReferenceType();
            int a = 23,b = 55;
            refAndValue.SwapValue(a, b);
            Console.WriteLine("{0}-{1}",a,b);
            refAndValue.SwapRefValue(ref a, ref b);
            Console.WriteLine("{0}-{1}", a, b);

            refAndValue.CheckOutKeyWordByValue(b);
            Console.WriteLine(b);
            refAndValue.CheckOutKeyWordByRef(out b);
            Console.WriteLine(b);*/
        }
    }
}
