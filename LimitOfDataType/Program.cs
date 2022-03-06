using System;

namespace LimitOfDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte number = 15;
            Console.WriteLine(number);
            Console.ReadLine();
            Console.WriteLine("Byte");
            Console.WriteLine("Max={0} Min={1}", Byte.MaxValue, byte.MinValue);
            Console.WriteLine("sByte");
            Console.WriteLine("Max={0} Min=  {1}", sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("int");
            Console.WriteLine("Max={0} Min={1}", int.MaxValue, int.MinValue);
            Console.WriteLine("double");
            Console.WriteLine("Max={0} Min={1}", double.MaxValue, double.MinValue);
        }
    }
}
